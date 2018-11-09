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
    public partial class formTabellone : Form
    {
        public List<CUtente> Utenti { get; set; }
        private double MontePremi;
        private List<string> Vincitori;
        public IConnection Connection { get; set; }
        public IModel Channel { get; set; }

        public ucCasella[,] Caselle { get; set; }
        public List<CCartella> CartelleDisponibili { get; set; }

        private List<int> daEstrarre;
        private int Arrivati;
        private int Premio;
        private double[] SoldiPremi;
        private bool CartelleInviate;
        private List<string> QueueCreate;
        private bool AvvisaCartelle;
        private Random r = new Random();

        public formTabellone(List<CCartella> Cartelle)
        {
            InitializeComponent();
            Premio = 0;
            QueueCreate = new List<string>();
            AvvisaCartelle = true;
            CartelleInviate = false;
            Arrivati = 0;
            CartelleDisponibili = new List<CCartella>();
            Vincitori = new List<string>();
            for (int i = 0; i < Cartelle.Count(); i++)
            {
                CartelleDisponibili.Add(new CCartella(Cartelle[i].Cartella));
            }
        }

        private CUtente GetUtente(string Username)
        {
            foreach (CUtente u in Utenti)
            {
                if (u.Username == Username)
                    return u;
            }
            return null;
        }
        public void GeneraCode(List<CUtente> Utenti, IConnection conn, IModel chan)
        {
            this.Channel = chan;
            this.Connection = conn;
            this.Utenti = new List<CUtente>();
            SoldiPremi = new double[6];
            Channel.ExchangeDeclare("Utenti", ExchangeType.Fanout, false, false, null);
            var consumer = new EventingBasicConsumer(Channel);
            daEstrarre = new List<int>();
            for (int i = 0; i < Utenti.Count; i++)
            {
                this.Utenti.Add(new CUtente(Utenti[i].Username, Utenti[i].NumCartelle));
            }
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var props = ea.BasicProperties;

                string message = Encoding.UTF8.GetString(body);
                int oggetto = (int)props.Headers["Oggetto"];
                switch (oggetto)
                {
                    case 0:
                        if (message != "")
                        {
                            Vincitori.Add(message);
                        }
                        Arrivati++;
                        if (Arrivati == this.Utenti.Count())
                        {
                            Arrivati = 0;
                            AbilitaEstrazione();
                        }
                        break;
                    case 1:
                        for (int i = 0; i < this.Utenti.Count(); i++)
                        {
                            if (this.Utenti[i].Username == message)
                            {
                                this.Utenti[i].NumCartelle = (int)props.Headers["NumCartelle"];
                                break;
                            }
                        }
                        Arrivati++;
                        if (Arrivati == this.Utenti.Count())
                        {
                            Arrivati = 0;
                            InviaCartelle();
                            AbilitaEstrazione();
                            CalcolaPremi();
                            CartelleInviate = true;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < this.Utenti.Count(); i++)
                        {
                            if (this.Utenti[i].Username == message)
                            {
                                this.Utenti.RemoveAt(i);
                                break;
                            }
                        }
                        if (this.Utenti.Count() != 0)
                        {
                            MessageBox.Show(message + " si è disconnesso!", "", MessageBoxButtons.OK);
                            if (Arrivati == this.Utenti.Count())
                            {
                                Arrivati = 0;
                                if (!CartelleInviate)
                                {
                                    CartelleInviate = true;
                                    InviaCartelle();
                                    CalcolaPremi();
                                }
                                AbilitaEstrazione();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tutti gli utenti si sono disconnessi", "", MessageBoxButtons.OK);
                            this.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.Hide();
                                EliminaCode();
                                Channel.Close();
                                Connection.Close();
                                Channel.Dispose();
                                Connection.Dispose();
                                formCaricamento formCaricamento = new formCaricamento();
                                AvvisaCartelle = false;
                                formCaricamento.Closed += (s, args) => this.Close();
                                formCaricamento.ShowDialog();
                            });
                        }
                        break;
                }
            };
            for (int i = 0; i < this.Utenti.Count; i++)
            {
                QueueCreate.Add("CS" + this.Utenti[i].Username);
                Channel.QueueDeclare("SC" + this.Utenti[i].Username, false, false, false, null);
                Channel.ExchangeDeclare("SC" + this.Utenti[i].Username, ExchangeType.Direct, false, false, null);
                Channel.QueueBind("SC" + this.Utenti[i].Username, "SC" + this.Utenti[i].Username, "");
                Channel.QueueBind("SC" + this.Utenti[i].Username, "Utenti", "");
                Channel.QueueDeclare("CS" + this.Utenti[i].Username, false, false, false, null);
                Channel.ExchangeDeclare("CS" + this.Utenti[i].Username, ExchangeType.Direct, false, false, null);
                Channel.QueueBind("CS" + this.Utenti[i].Username, "CS" + this.Utenti[i].Username, "");
                Channel.BasicConsume(queue: "CS" + this.Utenti[i].Username, autoAck: true, consumer: consumer);
            }
            GeneraDaEstrarre();
        }

        private void CalcolaPremi()
        {
            MontePremi = 0;
            for (int i = 0; i < this.Utenti.Count; i++)
            {
                MontePremi += this.Utenti[i].NumCartelle;
            }

            SoldiPremi[4] = Math.Round(0.3 * MontePremi, 1);
            SoldiPremi[5] = Math.Round(0.20 * MontePremi, 1);
            SoldiPremi[3] = Math.Round(0.20 * MontePremi, 1);
            SoldiPremi[2] = Math.Round(0.15 * MontePremi, 1);
            SoldiPremi[1] = Math.Round(0.10 * MontePremi, 1);
            SoldiPremi[0] = Math.Round(0.05 * MontePremi, 1);
        }

        private void GeneraDaEstrarre()
        {
            tlpTabellone.Controls.Clear();
            Caselle = new ucCasella[9, 10];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    daEstrarre.Add(j + 1 + 10 * i);
                    Caselle[i, j] = new ucCasella(j + 1 + 10 * i, tlpTabellone.Width / 9, tlpTabellone.Height / 9);
                    tlpTabellone.Controls.Add(Caselle[i, j], j, i);
                }
            }
        }
        private void InviaCartelle()
        {
            foreach (CUtente u in Utenti)
            {
                string message = "";
                CCartella[] Cartelle = RichiediCartelle(u.NumCartelle);
                foreach (CCartella c in Cartelle)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            message += c.Cartella[i, j] + " ";
                        }
                    }
                }
                Invia("SC" + u.Username, 0, message);
            }
        }



        private CCartella[] RichiediCartelle(int N)
        {
            CCartella[] Cartelle = new CCartella[N];
            if (N > CartelleDisponibili.Count())
            {
                CartelleDisponibili.AddRange(CGeneraCartelle.Genera(N - CartelleDisponibili.Count()));
            }
            for (int i = 0; i < N; i++)
            {
                Cartelle[i] = new CCartella(CartelleDisponibili[N - 1 - i].Cartella);
                CartelleDisponibili.RemoveAt(N - 1 - i);
            }

            return Cartelle;
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            btnEstrai.Enabled = false;
            int i = r.Next(daEstrarre.Count());
            int el = daEstrarre[i] - 1;
            daEstrarre.RemoveAt(i);
            lblNumero.Text = (el + 1).ToString();
            Caselle[el / 10, el % 10].Copri();
            Invia("Utenti", 1, (el + 1).ToString());
        }

        private void Invia(string Exchange, int Oggetto, string messaggio)
        {
            var props = Channel.CreateBasicProperties();
            props.Headers = new Dictionary<string, object>();
            props.Headers.Add("Oggetto", Oggetto);
            byte[] body = Encoding.UTF8.GetBytes(messaggio);
            Channel.BasicPublish(Exchange, "", props, body);
        }

        private void Resetta()
        {
            btnEstrai.Enabled = false;
            CartelleInviate = false;
            Invia("Utenti", 4, "Y");
            Premio = 0;
            Arrivati = 0;
            GeneraDaEstrarre();
            for (int i = 0; i < 6; i++)
            {
                tlpStorico.Controls["lblVincitori" + i].Text = "";
            }
            tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Regular);
            tlpStorico.Controls["lblPremio0"].Font = new Font(tlpStorico.Controls["lblPremio0"].Font, FontStyle.Bold);
            lblNumero.Text = "";
            MontePremi = 0;
        }

        private void FinePartita()
        {
            using (formFinePartita f = new formFinePartita())
            {
                DialogResult r = f.ShowDialog();
                if (r == DialogResult.Yes)
                {
                    Resetta();
                }
                else
                {
                    Invia("Utenti", 4, "N");
                    this.Hide();
                    EliminaCode();
                    Channel.Close();
                    Connection.Close();
                    Channel.Dispose();
                    Connection.Dispose();
                    formCaricamento formCaricamento = new formCaricamento();
                    AvvisaCartelle = false;
                    formCaricamento.Closed += (s, args) => this.Close();
                    formCaricamento.ShowDialog();
                }
            }
        }
        private void AbilitaEstrazione()
        {
            if (this.btnEstrai.InvokeRequired)
            {
                this.btnEstrai.BeginInvoke((MethodInvoker)delegate () {
                    if (daEstrarre.Count() != 0)
                        btnEstrai.Enabled = true;
                    else
                    {
                        FinePartita();
                    }
                });
            }
            else
            {
                if (daEstrarre.Count() != 0)
                    btnEstrai.Enabled = true;
                else
                {
                    FinePartita();
                }
            }

            Arrivati = 0;
            if (Vincitori.Count() > 0)
            {
                string stringaVincitori = "";
                string s = (SoldiPremi[Premio] / (double)Vincitori.Count()).ToString();
                MontePremi -= SoldiPremi[Premio];
                foreach (string u in Vincitori)
                {
                    Invia("SC" + u, 3, s);
                    stringaVincitori += (u + " - ");
                }
                stringaVincitori = stringaVincitori.Remove(stringaVincitori.Length - 3, 3);
                if (this.tlpStorico.InvokeRequired)
                {
                    this.tlpStorico.BeginInvoke((MethodInvoker)delegate () {
                        tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Regular);
                        tlpStorico.Controls["lblVincitori" + Premio].Text = stringaVincitori;

                        if (Premio < 5)
                        {
                            Premio++;
                            tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Bold);
                        }
                        else
                        {
                            FinePartita();
                        }
                    });
                }
                else
                {
                    tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Regular);
                    tlpStorico.Controls["lblVincitori" + Premio].Text = stringaVincitori;

                    if (Premio < 5)
                    {
                        Premio++;
                        tlpStorico.Controls["lblPremio" + Premio].Font = new Font(tlpStorico.Controls["lblPremio" + Premio].Font, FontStyle.Bold);
                    }
                    else
                    {
                        FinePartita();
                    }
                }

                Vincitori.Clear();
                foreach (CUtente u in Utenti)
                {
                    Invia("SC" + u.Username, 2, stringaVincitori);
                }
            }

        }

        private void formTabellone_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AvvisaCartelle)
            {
                DialogResult r = MessageBox.Show("Sicuro di voler terminare la partita in corso?", "", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    Invia("Utenti", 4, "N");
                    EliminaCode();
                }
                else
                {
                    e.Cancel = true;
                }
            }
           
        }

        private void EliminaCode()
        {
            foreach (string u in QueueCreate)
            {
                try
                {
                    Channel.QueueDelete(u, false, false);
                }
                catch (Exception) { }

            }
        }

        private void btnNuovaPartita_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Sicuro di voler iniziare una nuova partita?", "", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                int totCartelle = 0;
                foreach (CUtente u in Utenti)
                {
                    totCartelle += u.NumCartelle;
                }
                foreach (CUtente u in Utenti)
                {
                    Invia("SC" + u.Username, 3, ((double)u.NumCartelle)*MontePremi/ ((double)totCartelle) + "");
                }
                Resetta();
            }
        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            AvvisaCartelle = true;
            this.Close();
        }

        private void btnNuovaLobby_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Sicuro di voler terminare la partita in corso e aprire una nuova lobby?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Invia("Utenti", 4, "N");
                this.Hide();
                EliminaCode();
                Channel.Close();
                Connection.Close();
                Channel.Dispose();
                Connection.Dispose();
                formCaricamento formCaricamento = new formCaricamento();
                AvvisaCartelle = false;
                formCaricamento.Closed += (s, args) => this.Close();
                formCaricamento.ShowDialog();
            }
        }

    }
}
