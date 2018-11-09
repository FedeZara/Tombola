using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneraCartelle
{
    class CGeneraCartelle
    {
        private static Random r;
        private static List<int>[] daInserire;
        private static int[] spaziPerRiga;
        private static int[] spaziPerCartella;
        private static int[] spaziPerColonna;
        private static int[] numeriPerRiga;
        private static int[] numeriPerCartella;
        private static int[] numeriPerColonna;
        private static List<CCartella> l;
        private static int[,] m;

        public static void Inizializza()
        {
            l = new List<CCartella>();
            m = new int[18, 9];
            daInserire = new List<int>[9];
            spaziPerColonna = new int[9];
            numeriPerColonna = new int[9];
            for (int i = 0; i < 9; i++)
            {
                spaziPerColonna[i] = 0;
                numeriPerColonna[i] = 0;
            }
            AggiornaDaInserire();
            spaziPerRiga = new int[18];
            spaziPerCartella = new int[6];
            numeriPerRiga = new int[18];
            numeriPerCartella = new int[6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    spaziPerRiga[i * j] = 0;
                    numeriPerRiga[i * j] = 0;
                }

                spaziPerCartella[i] = 0;
                numeriPerCartella[i] = 0;
            }
            r = new Random();
        }
        public static List<CCartella> GeneraMetodoEuristico(int n)
        {
            Inizializza();
            GeneraRicorsivo(0, 0, n);
            return l;
        }

        public static List<CCartella> Genera(int n)
        {
            Inizializza();
            for (int i = 0; i < n; i++)
                l.Add(GeneraCartella());
            return l;
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
            for(int i=0; i<3; i++)
            {
                int numSpazi = 0;
                for(int j=0; j<9; j++)
                {
                    bool trovato = true;
                    do
                    {
                        r = new Random();
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
                    r = new Random();
                    int indice = r.Next(9);
                    if (Matrice[i, indice] != -1)
                    {
                        Matrice[i, indice] = -1;
                        numSpazi++;
                    }
                }
            }

            stampaMatrice(Matrice);
            

            CCartella c = new CCartella(Matrice);
            return c;
        }

        static private bool GeneraRicorsivo(int x, int y, int n)
        {
            if (y > 17)
            {
                stampaMatrice();/*
                int[,] mNum = new int[18, 9];
                for (int i=0; i<9; i++)
                {
                    int[] IndiciCasuali = new int[daInserire[i].Count()];
                    for (int j = 0; j < IndiciCasuali.Length; j++)
                        IndiciCasuali[j] = j;
                    IndiciCasuali = IndiciCasuali.OrderBy(e => r.Next()).ToArray();
                    int IndiciCasualiIndice = 0;
                    for(int j = 0; j < 18; j++)
                    {
                        if (m[j, i] == 1)
                        {
                            mNum[j, i] = daInserire[i].ElementAt(IndiciCasuali[IndiciCasualiIndice]);
                            IndiciCasualiIndice++;
                        }
                        else
                            mNum[j, i] = -1;
                    }
                }
                for (int i=0; i<6; i++)
                {
                    int[,] mC = new int[3, 9];
                    for(int j=0; j<3; j++)
                    {
                        for(int k=0; k<9; k++)
                        {
                            mC[j, k] = mNum[j * i, k];
                        }
                    }
                    l.Add(new CCartella(mC));
                }
                if (l.Count() == n)
                    return true;*/
                return false;
            }
            int numSpazi = 0;
            int numNumeri = 0;
            int numCartella = y / 3;
            
            for (int i=0; i<3; i++)
            {
                if (m[numCartella * 3 + i, x] == -1)
                    numSpazi++;
                else if (m[numCartella * 3 + i, x] == 1)
                    numNumeri++;
            }
            /*Console.Clear();
            Console.WriteLine(numSpazi + " " + numNumeri);
            stampaMatrice();*/
            if(m[y, x] == 0)
            {
                r = new Random();
                if (r.Next(100) < 50)
                {
                    if (AggiungiNumero(x, y, numNumeri, numCartella, n))
                        return true;
                    if (AggiungiSpazio(x, y, numSpazi, numCartella, n))
                        return true;
                }
                else
                {
                    if (AggiungiSpazio(x, y, numSpazi, numCartella, n))
                        return true;
                    if (AggiungiNumero(x, y, numNumeri, numCartella, n))
                        return true;
                }

                m[y, x] = 0;

                return false;
            }
            else
            {
                return GeneraRicorsivo((x + 1) % 9, y + (x + 1) / 9, n);
            }
        }

        private static bool AggiungiNumero(int x, int y, int numNumeri, int numCartella, int n)
        {
            if (numeriPerRiga[y] < 5 && numeriPerCartella[y / 3] < 15 && numeriPerColonna[x] < daInserire[x].Count() && (numCartella > 3 || (numCartella <= 3 && numNumeri < 2)) && (numCartella != 4 || (numCartella == 4 && numeriPerColonna[x] < daInserire[x].Count()-1)))
            {
                if (numNumeri == 1 && y % 3 == 1)
                {
                    m[y + 1, x] = -1;
                    spaziPerRiga[y + 1]++;
                    spaziPerCartella[y / 3]++;
                    spaziPerColonna[x]++;
                }
                
                m[y, x] = 1;
                numeriPerRiga[y]++;
                numeriPerCartella[y / 3]++;
                numeriPerColonna[x]++;
                if (numeriPerColonna[x] == daInserire[x].Count())
                {
                    for(int i=y+1; i<18; i++)
                    {
                        m[i, x] = -1;
                        spaziPerRiga[i]++;
                        spaziPerCartella[i / 3]++;
                        spaziPerColonna[x]++;
                    }
                }
                bool Finito = GeneraRicorsivo((x + 1) % 9, y + (x + 1) / 9, n);
                if (numeriPerColonna[x] == daInserire[x].Count())
                {
                    for (int i = y + 1; i < 18; i++)
                    {
                        m[i, x] = 0;
                        spaziPerRiga[i]--;
                        spaziPerCartella[i / 3]--;
                        spaziPerColonna[x]--;
                    }
                }
                numeriPerRiga[y]--;
                numeriPerCartella[y / 3]--;
                numeriPerColonna[x]--;
                if (numNumeri == 1 && y % 3 == 1)
                {
                    m[y + 1, x] = 0;
                    spaziPerRiga[y + 1]--;
                    spaziPerCartella[y / 3]--;
                    spaziPerColonna[x]--;
                }
                if (Finito)
                    return true;
            }
            return false;
            
        }

        private static bool AggiungiSpazio(int x, int y, int numSpazi, int numCartella, int n)
        {
            if (spaziPerRiga[y] < 4 && spaziPerCartella[y / 3] < 12 && spaziPerColonna[x] < (18-daInserire[x].Count()) && (numCartella > 3 || (numCartella <= 3 && numSpazi < 2)) && (numCartella != 4 || (numCartella == 4 && spaziPerColonna[x] < (17 - daInserire[x].Count()))))
            {
                if (numSpazi == 1 && y % 3 == 1)
                {
                    m[y + 1, x] = 1;
                    numeriPerRiga[y + 1]++;
                    numeriPerCartella[y / 3]++;
                    numeriPerColonna[x]++;
                }
                m[y, x] = -1;
                spaziPerRiga[y]++;
                spaziPerCartella[y / 3]++;
                spaziPerColonna[x]++;
                if (spaziPerColonna[x] == (18 - daInserire[x].Count()))
                {
                    for (int i = y + 1; i < 18; i++)
                    {
                        m[i, x] = 1;
                        numeriPerRiga[i]++;
                        numeriPerCartella[i / 3]++;
                        numeriPerColonna[x]++;
                    }
                }
                bool Finito = GeneraRicorsivo((x + 1) % 9, y + (x + 1) / 9, n);
                if (spaziPerColonna[x] == (18 - daInserire[x].Count()))
                {
                    for (int i = y + 1; i < 18; i++)
                    {
                        m[i, x] = 0;
                        numeriPerRiga[i]--;
                        numeriPerCartella[i / 3]--;
                        numeriPerColonna[x]--;
                    }
                }
                spaziPerRiga[y]--;
                spaziPerCartella[y / 3]--;
                spaziPerColonna[x]--;
                if (numSpazi == 1 && y % 3 == 1)
                {
                    m[y + 1, x] = 0;
                    numeriPerRiga[y + 1]--;
                    numeriPerCartella[y / 3]--;
                    numeriPerColonna[x]--;
                }
                if (Finito)
                    return true;
            }
            return false;
        }
        private static void stampaMatrice()
        {
            for(int i=0; i<18; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (m[i, j] != -1)
                        Console.Write(" ");
                    Console.Write(m[i, j] + " ");
                }
                  
                Console.WriteLine();
            }
        }

        private static void stampaMatrice(int[,] Matrice)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Matrice[i, j] != -1 && Matrice[i,j] < 10)
                        Console.Write(" ");
                    Console.Write(Matrice[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
