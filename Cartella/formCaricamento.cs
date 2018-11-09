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
using System.Threading;

namespace Cartella
{
    public partial class formCaricamento : Form
    {
        public IModel Channel { get; set; }
        public IConnection Connection { get; set; }
        public IConnectionFactory Factory { get; set; }
        public bool Connesso { get; set; }
        public System.Threading.Timer ProvaConnessione { get; set; }

        public formCaricamento()
        {
            InitializeComponent();
            Factory = new ConnectionFactory{ UserName = "default" , Password = "default", HostName = "tombola.ddns.net"};
            Connesso = false;
            ProvaConnessione = new System.Threading.Timer(new System.Threading.TimerCallback(Connetti), null, 0, 1000);
        }

        private void Connetti(object Sender)
        {
            try
            {
                Connection = Factory.CreateConnection();
                Channel = Connection.CreateModel();

                this.Connesso = true;
            }
            catch (Exception )
            {
         
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Connesso)
            {
                ProvaConnessione.Dispose();
                timer1.Enabled = false;
                this.Hide();
                formSchermataPrincipale c = new formSchermataPrincipale();
                c.Channel = Channel;
                c.Connection = Connection;

                c.ShowDialog();
                this.Close();
            }
        }

        private void formCaricamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
