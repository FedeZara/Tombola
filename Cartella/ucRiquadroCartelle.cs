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

    public partial class ucRiquadroCartelle : UserControl
    {
        private int mNumCartelle;
        private float mSaldo;
        private string mUsername;
        private ucCartella[] mCartelle;
        private TableLayoutPanel mtlpRiquadroCartelle;

        public TableLayoutPanel tlpRiquadroCartelle
        {
            get { return mtlpRiquadroCartelle; }
            set { mtlpRiquadroCartelle = value; }
        }
        public int NumCartelle
        {
            get { return mNumCartelle; }
            set { mNumCartelle = value; }
        }

        public ucCartella[] Cartelle
        {
            get { return mCartelle; }
            set { mCartelle = value; }
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

        public ucRiquadroCartelle(float Saldo, string Username, int NumCartelle, Size Dimensioni, string message)
        {
            InitializeComponent();
      
            this.NumCartelle = NumCartelle;
            this.Saldo = Saldo;
            
            this.Username = Username;

            tlpRiquadroCartelle = new TableLayoutPanel();
            tlpRiquadroCartelle.RowStyles.Clear();


            this.Size = Dimensioni;

            tlpRiquadroCartelle.Size = Dimensioni;

            tlpRiquadroCartelle.ColumnStyles.Clear();
            switch (NumCartelle)
            {
                case 1:
                    tlpRiquadroCartelle.ColumnCount = 1;
                    tlpRiquadroCartelle.RowCount = 1;
                    break;
                case 2:
                    tlpRiquadroCartelle.ColumnCount = 1;
                    tlpRiquadroCartelle.RowCount = 2;
                    break;
                case 3:
                case 4:
                    tlpRiquadroCartelle.ColumnCount = 2;
                    tlpRiquadroCartelle.RowCount = 2;
                    break;
                case 5:
                case 6:
                    tlpRiquadroCartelle.ColumnCount = 2;
                    tlpRiquadroCartelle.RowCount = 3;
                    break;
            }



            for (int i=0; i<tlpRiquadroCartelle.ColumnCount; i++)
            {
                tlpRiquadroCartelle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tlpRiquadroCartelle.ColumnCount));
            }

            for (int i = 0; i < tlpRiquadroCartelle.RowCount; i++) { 
                tlpRiquadroCartelle.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / tlpRiquadroCartelle.RowCount));
            }

            AggiungiCartelle(message);

            for (int i = 0; i < tlpRiquadroCartelle.RowCount; i++)
            {
                for (int j = 0; j < tlpRiquadroCartelle.ColumnCount; j++)
                {
                    int Indice = j + i * tlpRiquadroCartelle.ColumnCount;
                    if (Indice < NumCartelle)
                    {
                        tlpRiquadroCartelle.Controls.Add(Cartelle[Indice], j, i);
                    }
                }
            }

            this.Controls.Add(tlpRiquadroCartelle);
        }

        private void AggiungiCartelle(string message)
        {
            Cartelle = new ucCartella[NumCartelle];
            string[] splitMessage = message.Split(' ');
            int splitMessageIndex = 0;
           
            for (int i=0; i<NumCartelle; i++)
            {
                int[,] Tabella = new int[3, 9];
                for (int x=0; x<3; x++)
                {
                    for(int j=0; j<9; j++)
                    {
                        Tabella[x, j] = Int32.Parse(splitMessage[splitMessageIndex]);
                        splitMessageIndex++;
                    }
                }
                Cartelle[i] = new ucCartella(Tabella, tlpRiquadroCartelle.Width / tlpRiquadroCartelle.ColumnCount, tlpRiquadroCartelle.Height / tlpRiquadroCartelle.RowCount);
            }
        }

        public bool Copri(int Numero, int Premio)
        {
            bool Vinto = false;
            for (int i=0; i<Cartelle.Length; i++)
            {
                if (Cartelle[i].Copri(Numero, Premio))
                    Vinto = true;
            }
            return Vinto;
        }
    }
}
