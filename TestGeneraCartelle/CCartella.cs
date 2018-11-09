using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneraCartelle
{
    public class CCartella
    {

        public int[,] Cartella { get; set; }

        public CCartella(int[,] Cartella)
        {
            this.Cartella = new int[3, 9];
            for (int i = 0; i < Cartella.GetLength(0); i++)
            {
                for (int j = 0; j < Cartella.GetLength(1); j++)
                {
                    this.Cartella[i, j] = Cartella[i, j];
                }
            }
        }
    }
}
