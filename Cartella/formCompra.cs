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
    public partial class formCompra : Form
    {

        public ucCompra Compra { get; set; }
        public formCompra(IModel Channel, IConnection Connection, float Saldo, string Username, bool UsernameScelto)
        {
            InitializeComponent();
            Compra = new ucCompra(Saldo, Username, UsernameScelto);
            Compra.Channel = Channel;
            Compra.Connection = Connection;
            this.Controls.Add(Compra);
            Compra.BringToFront();
        }

        public formCompra(IModel Channel, IConnection Connection) : this(Channel, Connection, 10, "Giocatore", false) { }

        private void formCompra_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
