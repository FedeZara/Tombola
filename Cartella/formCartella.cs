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

namespace Cartella
{
    public partial class formCartella : Form
    {
        public formCartella()
        {
            InitializeComponent();
            Pannello1.Controls.Add(ucCompra.Istanza);
            
            ucCompra.Istanza.Left = (ucCompra.Istanza.Parent.Width - ucCompra.Istanza.Width) / 2;
            ucCompra.Istanza.Top = (ucCompra.Istanza.Parent.Height - ucCompra.Istanza.Height) / 2;


            ucCompra.Istanza.BringToFront();
        }
    }
}
