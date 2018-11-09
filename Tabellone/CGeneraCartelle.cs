using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabellone
{
    class CGeneraCartelle
    {
        private static Random r;
        private static List<int>[] daInserire;
        private static List<CCartella> Lista;

        public static void Inizializza()
        {
            Lista = new List<CCartella>();
            daInserire = new List<int>[9];
            AggiornaDaInserire();
            r = new Random();
        }

        public static List<CCartella> Genera(int n)
        {
            Inizializza();
            for (int i = 0; i < n; i++)
                Lista.Add(GeneraCartella());
            return Lista;
        }
        public static void AggiornaDaInserire()
        {
            for (int i = 0; i < 9; i++)
            {
                daInserire[i] = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    if (i == 0 && j == 0)
                        continue;
                    daInserire[i].Add(i * 10 + j);
                }
            }
            daInserire[8].Add(90);
        }
        public static CCartella GeneraCartella()
        {
            AggiornaDaInserire();
            int[,] Matrice = new int[3, 9];
            for (int i = 0; i < 3; i++)
            {
                int numSpazi = 0;
                for (int j = 0; j < 9; j++)
                {
                    bool trovato = true;
                    do
                    {
                        int Indice = r.Next(daInserire[j].Count());
                        int n = daInserire[j].ElementAt(Indice);
                        daInserire[j].RemoveAt(Indice);
                        if (j == 0)
                            n++;
                        for (int k = 0; k < i; k++)
                            if (Matrice[k, j] == n)
                                trovato = false;
                        Matrice[i, j] = n;
                    }
                    while (!trovato);
                }
                while (numSpazi < 4)
                {
                    int indice = r.Next(9);
                    if (Matrice[i, indice] != -1)
                    {
                        Matrice[i, indice] = -1;
                        numSpazi++;
                    }
                }
            }
            CCartella c = new CCartella(Matrice);
            return c;
        }
    }
}
