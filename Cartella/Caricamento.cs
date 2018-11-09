using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartella
{
    public partial class Caricamento : Form
    {
        private DateTime t;

        public Caricamento()
        {
            InitializeComponent();
            t = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tDelay = new TimeSpan(50000000);
            if(DateTime.Now - t > tDelay)
            {
                timer1.Enabled = false;
                this.Hide();
                Cartella c = new Cartella();

                c.ShowDialog();
                this.Close();
              
            }
        }
    }
}
