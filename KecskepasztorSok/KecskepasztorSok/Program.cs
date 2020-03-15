using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KecskepasztorSok
{
    class Program
    {
        static Random rnd=new Random();
        static int[] Kecskesuly = new int[10];
        static double[] KecskeMagassag = new double[10];
        static int DB = 10;
        static void Main(string[] args)
        {
            Feladat1AdatokFeltoltese();
            Feladat2LegDagibbKecske();
            Feladat3KecskekSulya();
            Feladat4SulySzerintiSorbarendezes();
            Feladat5Kijutnak();

            Console.ReadKey();
        }

        private static void Feladat5Kijutnak()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\n5.Feladat: Kijutnak a kecskék ha 300 cm a kerités?");
            Array.Sort(KecskeMagassag);
            Array.Reverse(KecskeMagassag);
            for (int k = 0; k < DB; k++)
            {
                Console.WriteLine("\t{0}",KecskeMagassag[k]);
            }
            
            double Sum = 0;
            int i = 0;
            while(Sum<=300)
            {
                Sum += KecskeMagassag[i];
                i++;
            }
            Console.WriteLine("\tEnnyi kecske kell, hogy egymásra álljon: {0}", i);
        }

        private static void Feladat4SulySzerintiSorbarendezes()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\n4.Feladat: Kecskék rendezése súly szerint");
            int tmp;
            double tmb2;
            for (int k = 0; k < DB; k++)
            {
                Console.Write(Kecskesuly[k] + ", ");
            }
           for (int i = DB - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Kecskesuly[j] < Kecskesuly[j + 1])
                    {
                        tmp = Kecskesuly[j];
                        tmb2 = KecskeMagassag[j];
                        Kecskesuly[j] = Kecskesuly[j + 1];
                        KecskeMagassag[j] = KecskeMagassag[j + 1];
                        Kecskesuly[j + 1] = tmp;
                        KecskeMagassag[j + 1] = tmb2;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n");
            for (int k = 0; k < DB; k++)
            {
                Console.WriteLine("{0,-2}. kecske\t {1,-5} kg \t{2,-5} cm", k+1, Kecskesuly[k], KecskeMagassag[k]);
            }
        }

        private static void Feladat3KecskekSulya()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\n3.Feladat: Kecskék össz súlya");
            double Suly = 0;
            for (int i = 0; i < DB; i++)
            {
                Suly+= Kecskesuly[i];
            }
            Console.WriteLine("\tA kecskék össz súlya: {0} kg", Suly);
        }

        private static void Feladat2LegDagibbKecske()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\n2.Feladat: Legsúlyosabb kecske");
            int MaxSuly = int.MinValue;
            double MaxMagassag = 0;
            int MaxSorszam = 0;
            for (int i = 0; i < DB; i++)
            {
                if(MaxSuly<Kecskesuly[i])
                {
                    MaxSuly = Kecskesuly[i];
                    MaxMagassag = KecskeMagassag[i];
                    MaxSorszam = i + 1;

                }
            }
            Console.WriteLine("\tA legsúlyosabb kecske: {0}kg\n\tA legsúlyosabb kecske magassága: {1} cm\n\tA legsúlyosabb kecske sorszáma: {2}", MaxSuly, MaxMagassag, MaxSorszam);

        }

        private static void Feladat1AdatokFeltoltese()
        {
            Console.WriteLine("1.Feladat: Adatok feltöltése");
            Console.WriteLine("\nKecske sorszáma \tKecske súlya \tKecske magasséga");
            for (int i = 0; i < DB; i++)
            {
                Kecskesuly[i] = rnd.Next(40,120);
                KecskeMagassag[i] = rnd.Next(410, 580) / 10.0;
                Console.WriteLine("{0,-3}.kecske\t\t{1,-3} kg\t\t{2,-5} cm", i+1, Kecskesuly[i], KecskeMagassag[i]);
            }
        }
    }
}
