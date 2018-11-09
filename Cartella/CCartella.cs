using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartella
{
    class CCartella
    {
        private int[,] mNumeri;

        public int[,] Numeri
        {
            get { return mNumeri; }
            set { mNumeri = value; }
        }

        public CCartella()
        {
            Numeri = new int[3, 9];
        }

        public CCartella(int[,] Numeri)
        {
            this.Numeri = Numeri;
        }

        public bool Copri(int num, int premio)
        {
            int col = num % 10 - 1;
            int rig = -1;
            for(int i=0; i < Numeri.GetLength(0); i++)
            {
                if(Numeri[i,col] == num)
                {
                    Numeri[i, col] = 0;
                    rig = i;
                    break;
                }
            }
            if(rig != -1)
            {
                if(premio < 4)
                {
                    int coperti = CopertiRiga(rig);
                    if (coperti == premio + 2)
                        return true;
                }
                else
                {
                    int coperte = 0;
                    for (int i=0; i < Numeri.GetLength(0); i++)
                    {
                        if (CopertiRiga(i) == 5)
                            coperte++;
                    }
                    if (coperte == premio - 2)
                        return true;
                }
            }

            return false;
        } 

        private int CopertiRiga(int riga)
        {
            int coperti = 0;
            for (int i = 0; i < Numeri.GetLength(1); i++)
            {
                if (Numeri[riga, i] == 0)
                    coperti++;
            }
            return coperti;
        }
    }
}
