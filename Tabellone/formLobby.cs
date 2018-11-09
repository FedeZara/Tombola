using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Windows.Forms;

namespace Tabellone
{
    public partial class formLobby : Form
    {
        public int Timer { get; set; }
        public IConnection Connection { get; set; }
        public IModel Channel { get; set; }

        private List<string> CodeTry;
        public List<CCartella> Cartelle { get; set; }
        public System.Threading.Thread GeneraCartelleThread { get; set; }
        private bool AvvisaCartelle;
        private void Inizializza()
        {
            InitializeComponent();
            AvvisaCartelle = true;
            btnInizia.Enabled = false;
            Timer = 60;
            CodeTry = new List<string>();
            GeneraCartelleThread = new System.Threading.Thread(GeneraCartelle);
            GeneraCartelleThread.Start();
            Channel.BasicQos(0, 1, false);
            Channel.QueueDeclare("qRichieste", false, false, false, null);

            var consumer = new EventingBasicConsumer(Channel);
            Channel.BasicConsume("qRichieste", false, consumer);
            consumer.Received += (ch, ea) =>
            {
                var body = ea.Body;
                var props = ea.BasicProperties;

                var replyProps = Channel.CreateBasicProperties();


                replyProps.CorrelationId = props.CorrelationId;
                string Username = Encoding.UTF8.GetString(body);
                if ((int)props.Headers["Oggetto"] == 0)
                {
                    string Codice = "" + Lobby.AggiungiUtente(Username);
                    var response = Encoding.UTF8.GetBytes(Codice);

                    CodeTry.Add("Try" + Username);
                    Channel.QueueDeclare("Try" + Username, false, false, false, null);
                    Channel.ExchangeDeclare("Try" + Username, ExchangeType.Direct, false, false, null);
                    Channel.QueueBind("Try" + Username, "Try" + Username, "");


                    Channel.BasicPublish(exchange: "Try" + Username, routingKey: "", basicProperties: replyProps, body: response);
                }
                else if ((int)props.Headers["Oggetto"] == 1)
                {
                    Lobby.RimuoviUtente(Username);
                }

                Channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            };

        }
        public formLobby(IConnection Conn, IModel Chan)
        {
            Connection = Conn;
            Channel = Chan;

            Inizializza();
        }
       
        private void GeneraCartelle()
        {
            Cartelle = CGeneraCartelle.Genera(180);
        }
        private void tCountDown_Tick(object sender, EventArgs e)
        {
            if (Lobby.Utenti.Count >= 2)
            {
                Timer--;
                if (!btnInizia.Enabled)
                    btnInizia.Enabled = true;
            }
            else if (btnInizia.Enabled)
                btnInizia.Enabled = false;
            lblTimer.Text = Timer + "";
            if(Timer == 0)
            {
                Inizia();
            }
        }

        private void Inizia()
        {
            AvvisaCartelle = false;
            EliminaCode();
            tCountDown.Dispose(); 
            this.Hide();
            formTabellone c = new formTabellone(Cartelle);
            c.GeneraCode(Lobby.Utenti, Connection, Channel);
            c.Closed += (s, args) => this.Close();
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inizia();
        }

        private void EliminaCode()
        {
            try
            {
                Channel.QueueDelete("qRichieste");
            }
            catch (Exception) { }
            foreach(string s in CodeTry)
            {
                try
                {
                    Channel.QueueDelete(s);
                }
                catch (Exception) { }
            }
            if (AvvisaCartelle)
            {
                foreach (CUtente u in Lobby.Utenti)
                {
                    try
                    {
                        Invia("SC" + u.Username, 4, "N");
                        Channel.QueueDelete("CS" + u.Username, false, false);
                    }
                    catch (Exception) { }
                }
            }
            
            CodeTry.Clear();
        
        }
        private void Invia(string Exchange, int Oggetto, string messaggio)
        {
            var props = Channel.CreateBasicProperties();
            props.Headers = new Dictionary<string, object>();
            props.Headers.Add("Oggetto", Oggetto);
            byte[] body = Encoding.UTF8.GetBytes(messaggio);
            Channel.BasicPublish(Exchange, "", props, body);
        }
        private void formLobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            EliminaCode();

        }
    }
}
