using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartella
{
    public partial class ucCartella : UserControl
    {
        private ucCasella[,] mCaselle;
        private int[,] mTabella;
        private int[] mCoperte;

        public ucCasella[,] Caselle
        {
            get { return mCaselle; }
            set { mCaselle = value; }
        }

        public int[,] Tabella
        {
            get { return mTabella; }
            set { mTabella = value; }
        }

        public int[] Coperte
        {
            get { return mCoperte; }
            set { mCoperte = value; }
        }
        public ucCartella(int[,] Caselle, int Width, int Height)
        {
            InitializeComponent();
            Coperte = new int[3];
            Tabella = new int[3, 9];
            this.Caselle = new ucCasella[3, 9];
            
            if ((double)Width / Height >= 2.19)
            {
                Width = (int)(Height * 2.19);
            }
            else
            {
                Height = (int)(Width / 2.19);
            }

            tlpCartella.Size = new Size(((int)(0.98 * Width)/9)*9, (int)((0.714 * Height)/3)*3);
            this.Size = new Size(Width,Height);
            pnlSfondo.Size = new Size((int)(0.98 * Width), (int)(0.98 * Height));
            pnlSfondo.Location = new Point((Width - pnlSfondo.Width) / 2, (Height - pnlSfondo.Height) / 2);
            pbScritta.Size = new Size((int)(0.532 * Width), (int)(0.421 * Height));
            pbScritta.Location = new Point((int)(0.0174*Width), (int)(-0.0786 * Height));

            foreach (ColumnStyle style in tlpCartella.ColumnStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Width = 100 / 9;
            }

            foreach (RowStyle style in tlpCartella.RowStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Height = 100 / 3;
            }
            tlpCartella.Location = new Point((Width - tlpCartella.Width) / 2, (int)(Height * 0.2619));

            for (int i=0; i<3; i++)
            {
                Coperte[i] = 0;
                for (int j=0; j<9; j++)
                {
                    this.Caselle[i,j] = new ucCasella(Caselle[i,j], tlpCartella.Width / 9, tlpCartella.Height / 3);
                    Tabella[i, j] = Caselle[i, j];
                    tlpCartella.Controls.Add(this.Caselle[i, j], j, i);
                }
            }
            this.Anchor = AnchorStyles.None;
        }

        public bool Copri(int num, int premio)
        {
            int col = num / 10;
            if (num == 90)
                col = 8;
            int rig = -1;
            for (int i = 0; i < Tabella.GetLength(0); i++)
            {
                if (Tabella[i, col] == num)
                {
                    Caselle[i, col].Copri();
                    Tabella[i, col] = 0;
                    Coperte[i]++;
                    rig = i;
                    break;
                }
            }
            if (rig != -1)
            {
                if (premio < 4 && Coperte[rig] == premio + 2)
                        return true;
                else
                {
                    int coperte = 0;
                    for (int i = 0; i < Tabella.GetLength(0); i++)
                    {
                        if (Coperte[i] == 5)
                            coperte++;
                    }
                    if (coperte == 3)
                        return true;
                }
            }
            return false;
        }
    }
}
