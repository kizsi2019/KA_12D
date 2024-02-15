using cbradio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdc_cbRadio
{
    class Program
    {
        
        static List<CBClass> lista = new List<CBClass>();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("cb.txt", Encoding.UTF8);
            string sor = sr.ReadLine(); 
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                CBClass cb = new CBClass(sor);
                lista.Add(cb);
            }
            sr.Close();

            Console.WriteLine("3. feladat");
            Console.WriteLine("Ennyi bejegyzés van a fájlban: " + lista.Count);


            Console.WriteLine("4. feladat");
            bool megvan = false;
            int i = 0;
            while (megvan == false && i < lista.Count)
            {
                if (lista[i].AdasDb == 4)
                {
                    megvan = true;
                    Console.WriteLine("Volt négy adást indító sofőr!");
                }
                i++;
            }
            if (megvan == false) Console.WriteLine("Nem volt négy adást indító sofőr!");

            Console.WriteLine("5. feladat");
            Console.WriteLine("Kérem egy sofőr nevét!");
            string bekertNev = Console.ReadLine();
            int osszAdasDB = 0;
            for (i = 0; i < lista.Count; i++)
            {
                if (lista[i].Nev == bekertNev)
                {
                    osszAdasDB += lista[i].AdasDb;
                }
            }
            if (osszAdasDB == 0)
            {
                Console.WriteLine("Nincs ilyen sofőr!");
            }
            else
            {
                Console.WriteLine("A sofőr által indított adások száma: " + osszAdasDB);
            }

            StreamWriter sw = new StreamWriter("cb2.txt");
            sw.WriteLine("Kezdés;Név;AdasDb");
            for (int j = 0; j < lista.Count; j++)
            {
                sw.WriteLine(lista[j].atSzamolPercre() + ";" + lista[j].Nev
                    + ";" + lista[j].AdasDb);
            }
            sw.Close();

            Console.WriteLine("8. feladat");
            List<string> nevek = new List<string>();
            for (i = 0; i < lista.Count; i++)
            {
                if (!nevek.Contains(lista[i].Nev))
                    nevek.Add(lista[i].Nev);
            }
            Console.WriteLine("Sofőrök száma: " + nevek.Count);

            Console.WriteLine("9. feladat: A legtöbb adást indító sofőr:");
           
            int maxAdasDb = lista[0].AdasDb;
            int maxIndex = 0;
            for (i = 0; i < lista.Count; i++)
            {
                if (lista[i].AdasDb > maxAdasDb)
                {
                    maxAdasDb = lista[i].AdasDb;
                    maxIndex = i;
                }
            }
            Console.WriteLine("A sofőr neve: " + lista[maxIndex].Nev);
            Console.WriteLine("Adások száma: " + maxAdasDb);

           
            List<int> hivasok = new List<int>();
            for (i = 0; i < nevek.Count; i++)
            {
                int osszesHivas = 0;
                for (int j = 0; j < lista.Count; j++)
                {
                    if (nevek[i] == lista[j].Nev)
                    {
                        osszesHivas += lista[j].AdasDb;
                    }
                }
                hivasok.Add(osszesHivas);
            }

            Console.WriteLine("A legtöbb hívás: " + hivasok.Max());
            Console.WriteLine("A legtöbb hívást indító sofőr:");
            for (i = 0; i < hivasok.Count; i++)
            {
                if (hivasok[i] == hivasok.Max())
                {
                    Console.WriteLine(nevek[i]);
                }
            }

            Console.ReadKey();
        }
    }
} 