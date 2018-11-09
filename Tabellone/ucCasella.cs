using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabellone
{
    public partial class ucCasella : UserControl
    {
        private bool mSelezionato;
        private int mNumero;

        public bool Selezionato
        {
            get { return mSelezionato; }
            set { mSelezionato = value; }
        }

        public int Numero
        {
            get { return mNumero; }
            set { mNumero = value; }
        }
        public ucCasella(int Numero, int Width, int Height)
        {
            InitializeComponent();
            this.Numero = Numero;
            if (Numero != -1)
                lblNumero.Text = Numero + "";
            lblNumero.Font = new Font("Georgia", lblNumero.Font.Size * Height / this.Height, FontStyle.Regular);
            this.Size = new Size(Width, Height);
            lblNumero.Size = new Size((int)(0.98 * Width), (int)(0.98 * Height));
            lblNumero.Location = new Point((Width - lblNumero.Width) / 2, (Height - lblNumero.Height) / 2);

        }

        public void Copri()
        {
            lblNumero.BackColor = Color.FromArgb(151, 0, 4);
            lblNumero.ForeColor = Color.White;
        }

        public void Seleziona()
        {
            lblNumero.BackColor = Color.LightYellow;
        }
    }
}
