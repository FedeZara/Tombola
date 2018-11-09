using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Cartella
{
    public partial class formSchermataPrincipale : Form
    {
        private ucRiquadroCartelle mRiquadroCartelle;
        private float mSaldo;
        private string mUsername;
        private int mNumCartelle;
        private int Premio;
        private bool AvvisaTabellone;
        public IModel Channel { get; set; }
        public IConnection Connection { get; set; }
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
        public ucRiquadroCartelle RiquadroCartelle
        {
            set { mRiquadroCartelle = value; }
            get { return mRiquadroCartelle; }
        }
        public formSchermataPrincipale()
        {
            InitializeComponent();
            AvvisaTabellone = true;
            Username = "***************************************";
        }

        private void DichiaraCode()
        {
            Channel.QueueDeclare("CS" + Username, false, false, false, null);
            Channel.ExchangeDeclare("CS" + Username, ExchangeType.Direct, false, false, null);
            Channel.QueueBind("CS" + Username, "CS" + Username, "");
            Channel.QueueDeclare("SC" + Username, false, false, false, null);
            Channel.ExchangeDeclare("SC" + Username, ExchangeType.Direct, false, false, null);
            Channel.QueueBind("SC" + Username, "SC" + Username, "");
            var consumer = new EventingBasicConsumer(Channel);
            Channel.BasicConsume("SC" + Username, true, consumer);

            consumer.Received += (ch, ea) =>
            {
                var body = ea.Body;
                var props = ea.BasicProperties;

                string message = Encoding.UTF8.GetString(body);
                int oggetto = (int)props.Headers["Oggetto"];
                switch (oggetto)
                {
                    case 0:
                        if (this.pnlRiquadroCartelle.InvokeRequired)
                        {
                            this.pnlRiquadroCartelle.BeginInvoke((MethodInvoker)delegate () {
                                RiquadroCartelle = new ucRiquadroCartelle(Saldo, Username, NumCartelle, pnlRiquadroCartelle.Size, message);
                                pnlRiquadroCartelle.Controls.Add(RiquadroCartelle);

                                RiquadroCartelle.BringToFront();
                            });
                        }
                        else
                        {
                            RiquadroCartelle = new ucRiquadroCartelle(Saldo, Username, NumCartelle, pnlRiquadroCartelle.Size, message);
                            pnlRiquadroCartelle.Controls.Add(RiquadroCartelle);

                            RiquadroCartelle.BringToFront();
                        }
                        break;
                    case 1:
                        if (this.mRiquadroCartelle.InvokeRequired)
                        {
                            this.mRiquadroCartelle.BeginInvoke((MethodInvoker)delegate () {
                                int num = Int32.Parse(message);
                                label2.Text = num + "";
                                if (mRiquadroCartelle.Copri(num, Premio))
                                    Invia("CS" + Username, 0, Username);
                                else
                                    Invia("CS" + Username, 0, "");
                            });
                        }
                        else
                        {
                            if (mRiquadroCartelle.Copri(Int32.Parse(message), Premio))
                                Invia("CS" + Username, 0, Username);
                            else
                                Invia("CS" + Username, 0, "");
                        }

                        break;
                    case 2:
                        if (this.tlpStorico.InvokeRequired)
                        {
                            this.tlpStorico.BeginInvoke((MethodInvoker)delegate () {
                                tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Regular);
                                tlpStorico.Controls["lblVincitori" + Premio].Text = message;
                                Premio++;
                                if (Premio < 6)
                                    tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Bold);

                            });
                        }
                        else
                        {
                            tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Regular);
                            tlpStorico.Controls["lblVincitori" + Premio].Text = message;
                            Premio++;
                            if (Premio < 6)
                                tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Bold);
                        }

                        break;
                    case 3:
                        Saldo += float.Parse(message);
                        if (this.lblConto.InvokeRequired)
                        {
                            this.lblConto.BeginInvoke((MethodInvoker)delegate () {
                                lblConto.Text = this.Saldo.ToString("0.00") + "€";
                            });
                        }
                        else
                        {
                            lblConto.Text = this.Saldo.ToString("0.00") + "€";
                        }

                        break;
                    case 4:
                        if (this.InvokeRequired)
                        {
                            this.BeginInvoke((MethodInvoker)delegate ()
                            {
                                if (message == "N")
                                {
                                    MessageBox.Show("Il tabellone ha deciso di concludere la partita.", "", MessageBoxButtons.OK);
                                    AvvisaTabellone = false;
                                    this.Close();
                                }
                                else
                                {
                                    if (MessageBox.Show("Il tabellone ha deciso di avviare una nuova partita. Vuoi continuare a giocare?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                    {
                                        Resetta();
                                        ApriSchermataCompra(true);
                                    }
                                    else
                                    {
                                        Invia("CS" + Username, 2, Username);
                                        AvvisaTabellone = false;
                                        this.Close();
                                    }
                                        
                                 
                                }
                            });
                        }
                        else
                        {
                            if (message == "N")
                            {
                                MessageBox.Show("Il tabellone ha deciso di concludere la partita.", "", MessageBoxButtons.OK);
                                AvvisaTabellone = false;
                                this.Close();
                            }
                            else
                            {
                                if (MessageBox.Show("Il tabellone ha deciso di avviare una nuova partita. Vuoi continuare a giocare?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Resetta();
                                    ApriSchermataCompra(true);
                                }
                                else
                                {
                                    Invia("CS" + Username, 2, Username);
                                    AvvisaTabellone = false;
                                    this.Close();
                                }

                            }
                        }
                        
                        break;
                }
            };
        }

        private void Resetta()
        {
            for (int i = 0; i < 6; i++)
            {
                tlpStorico.Controls["lblVincitori" + i].Text = "";
            }
            if (Premio == 6)
                Premio--;
            label2.Text = "";
            tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Regular);
            tlpStorico.Controls["lblPremio0"].Font = new Font(tlpStorico.Controls["lblPremio0"].Font, FontStyle.Bold);
            Premio = 0;
        }
        private void ApriSchermataCompra(bool UsernameScelto)
        {
            if (!UsernameScelto)
            {
                formCompra f = new formCompra(Channel, Connection);
                DialogResult r = f.ShowDialog();
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    this.NumCartelle = f.Compra.NumCartelle;
                    this.Saldo = f.Compra.Saldo;
                    this.Username = f.Compra.Username;

                    lblNome.Text = this.Username;
                    lblConto.Text = this.Saldo.ToString("0.00") + "€";
                    DichiaraCode();

                    var props = Channel.CreateBasicProperties();
                    props.Headers = new Dictionary<string, object>();
                    props.Headers.Add("Oggetto", 1);
                    props.Headers.Add("NumCartelle", NumCartelle);
                    byte[] body = Encoding.UTF8.GetBytes(Username);
                    Channel.BasicPublish("CS" + Username, "", props, body);
                }
                else
                {
                    AvvisaTabellone = false;
                    this.Close();
                }
            }
            else
            {
                formCompra f = new formCompra(Channel, Connection, Saldo, Username, true);
                DialogResult r = f.ShowDialog();
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    this.NumCartelle = f.Compra.NumCartelle;
                    this.Saldo = f.Compra.Saldo;
                    lblConto.Text = this.Saldo.ToString("0.00") + "€";
                    pnlRiquadroCartelle.Controls.Clear();

                    var props = Channel.CreateBasicProperties();
                    props.Headers = new Dictionary<string, object>();
                    props.Headers.Add("Oggetto", 1);
                    props.Headers.Add("NumCartelle", NumCartelle);
                    byte[] body = Encoding.UTF8.GetBytes(Username);
                    Channel.BasicPublish("CS" + Username, "", props, body);
                }
                else
                {
                    Invia("CS" + Username, 2, Username);
                    AvvisaTabellone = false;
                    this.Close();
                }
            }

        }
        private void Invia(string Exchange, int Oggetto, string messaggio)
        {
            var props = Channel.CreateBasicProperties();
            props.Headers = new Dictionary<string, object>();
            props.Headers.Add("Oggetto", Oggetto);
            byte[] body = Encoding.UTF8.GetBytes(messaggio);
            Channel.BasicPublish(Exchange, "", props, body);
        }
        private void formSchermataPrincipale_Shown(object sender, EventArgs e)
        {
            ApriSchermataCompra(false);
        }

        private void formSchermataPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Username != "***************************************")
            {
                if (RiquadroCartelle == null)
                {
                    try
                    {
                        if (AvvisaTabellone)
                        {
                            DialogResult r = MessageBox.Show("Sicuro di voler uscire dalla partita?", "", MessageBoxButtons.YesNo);
                            if (r == DialogResult.No)
                            {
                                e.Cancel = true;
                                return;
                            }

                            Invia("qRichieste", 1, Username);
                        }
 
                        Channel.QueueDelete("CS" + Username, false, false);
                    }
                    catch (Exception) { }
                }
                else
                {
                    if (AvvisaTabellone)
                    {
                        DialogResult r = MessageBox.Show("Sicuro di voler uscire dalla partita?", "", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                            Invia("CS" + Username, 2, Username);
                        else { 
                            e.Cancel = true;
                            return;
                        }
                    }
                }
                Channel.QueueDelete("SC" + Username, false, false);
            }

        }
    }
}
