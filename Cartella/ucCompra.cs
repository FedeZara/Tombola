using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Collections.Concurrent;

namespace Cartella
{
    public partial class ucCompra : UserControl
    {
        private int mNumCartelle;
        private float mSaldo;
        private string mUsername;
        public IModel Channel { get; set; }
        public IConnection Connection { get; set; }
        private bool UsernameScelto;

        public int NumCartelle
        {
            get { return mNumCartelle; }
            set { mNumCartelle = value; }
        }

        public float Saldo
        {
            get { return mSaldo; }
            set { mSaldo = value; }
        }
        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }
        public ucCompra() : this(10, "Computer 1", false) { }

        public ucCompra(float Saldo, string Username, bool UsernameScelto){
            InitializeComponent();
            NumCartelle = 1;
            this.UsernameScelto = UsernameScelto;
            if (UsernameScelto)
                tbUsername.Enabled = false;
            tbSaldo.Text = Saldo.ToString("0.00") + "€";
            lblSaldoIniziale.Text = Saldo.ToString("0.00") + "€    -";
            this.Saldo = Saldo-1;
            Aggiorna();
            this.Username = Username;
            tbUsername.Text = Username; 
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            NumCartelle++;
            Saldo--;
            Aggiorna();
        }

        private void Aggiorna()
        {
            lblSpesi.Text = NumCartelle.ToString("0.00") + "€";
            lblRimanenti.Text = (Saldo).ToString("0.00") + "€";
            if (NumCartelle == 1)
                btnRimuovi.Enabled = false;
            else
                btnRimuovi.Enabled = true;
            if (NumCartelle == 6 || Saldo < 1)
                btnAggiungi.Enabled = false;
            else
                btnAggiungi.Enabled = true;
            switch (NumCartelle)
            {
                case 1:
                    pbCartelle.Image = Cartella.Properties.Resources._11;
                    break;
                case 2:
                    pbCartelle.Image = Cartella.Properties.Resources._21;
                    break;
                case 3:
                    pbCartelle.Image = Cartella.Properties.Resources._31;
                    break;
                case 4:
                    pbCartelle.Image = Cartella.Properties.Resources._41;
                    break;
                case 5:
                    pbCartelle.Image = Cartella.Properties.Resources._51;
                    break;
                case 6:
                    pbCartelle.Image = Cartella.Properties.Resources._61;
                    break;
            }
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            NumCartelle--;
            Saldo++;
            Aggiorna();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if(tbUsername.Text.Length > 22)
            {
                lblVerifica.ForeColor = Color.Red;
                lblVerifica.Text = "Nome troppo lungo!";
                btnConferma.Enabled = false;
            }
            else
            {
                Username = tbUsername.Text;
                lblVerifica.ForeColor = Color.Green;
                lblVerifica.Text = "OK!";
                btnConferma.Enabled = true;
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (!UsernameScelto)
            {
                Channel.ExchangeDeclare("qRichieste", "direct", false, false, null);
                Channel.QueueDeclare("qRichieste", false, false, false, null);
                Channel.QueueBind("qRichieste", "qRichieste", "", null);
                Channel.QueueDeclare("Try" + Username, false, false, false, null);
                Channel.ExchangeDeclare("Try" + Username, ExchangeType.Direct, false, false, null);
                Channel.QueueBind("Try" + Username, "Try" + Username, "");
                var consumer = new EventingBasicConsumer(Channel);

                var props = Channel.CreateBasicProperties();

                var correlationId = Guid.NewGuid().ToString();
                props.CorrelationId = correlationId;
                props.Headers = new Dictionary<string, object>();
                props.Headers.Add("Oggetto", 0);

                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var response = Encoding.UTF8.GetString(body);
                    if (ea.BasicProperties.CorrelationId == correlationId)
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            int codice = Int32.Parse(response);
                            Channel.QueueDelete("Try" + Username);
                            if (codice == 0)
                            {
                                formCompra f = (formCompra)this.Parent;
                                f.DialogResult = DialogResult.OK;
                                f.Close();
                            }
                            else
                            {
                                lblVerifica.ForeColor = Color.Red;
                                if (codice == 1)
                                    lblVerifica.Text = "Lobby piena!";
                                else
                                    lblVerifica.Text = "Username già in uso!";
                                this.btnAggiungi.Enabled = true;
                                this.btnConferma.Enabled = true;
                                this.btnRimuovi.Enabled = true;
                            }
                        });
                        
                    }
                };
                var messageBytes = Encoding.UTF8.GetBytes(Username);
                Channel.BasicPublish("qRichieste", "", props, messageBytes);

                Channel.BasicConsume(consumer: consumer, queue: "Try" + Username, autoAck: true);

                this.btnAggiungi.Enabled = false;
                this.btnConferma.Enabled = false;
                this.btnRimuovi.Enabled = false;
            }
            else
            {
                formCompra f = (formCompra)this.Parent;
                f.DialogResult = DialogResult.OK;
                f.Close();
            }
        }
        
    }
}
