using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Tracing;

namespace cbradio
{
    internal class Program
    {
        static List<Data> adatok = new List<Data>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("cb.txt");
            string sor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                Data cb = new Data(sor);
                adatok.Add(cb);
            }
            sr.Close();
            Console.WriteLine("3.feladat: Bejegyzések: " + adatok.Count + "db");

            bool megvan = false;
            int i = 0;
            while (megvan == false && i < adatok.Count)
            {
                if (adatok[i].Adatdb == 4 && adatok[i].Perc == 1)
                {
                    megvan = true;
                    Console.WriteLine("4.feladat: Volt aki egy percen belül 4 adást indított");
                }
                i++;
            }
            if (megvan == false)
            {
                Console.WriteLine("4.feladat: Nem volt aki egy percen belül 4 adást indított");
            }

            Console.WriteLine("Kérek egy nevet: ");
            string input = Console.ReadLine();
            int vki = 0;
            for (i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].Nev == input)
                {
                    vki += adatok[i].Adatdb;
                }
            }
            if (vki == 0)
            {
                Console.WriteLine("Nincs ilyen sofőr");
            }
            else
            {
                Console.WriteLine("Hívások száma: " + vki);
            }

            int sszam = ;











            Console.ReadLine();
        }
    }
}
