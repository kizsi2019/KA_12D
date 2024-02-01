using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            List<Adatok> adatok = new List<Adatok>();
            //3. feladat
            foreach (var sor in File.ReadAllLines("toto.txt").Skip(1))
            {
                adatok.Add(new Adatok(sor));
            }
            Console.WriteLine($"3. feladat: Fordulók száma: {adatok.Count}");

            //4. feladat
            int teliTalalatos = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                teliTalalatos += adatok[i].T13p1;
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {teliTalalatos} db");

            //5. feladat
            List<double> osszes = new List<double>();
            for (int i = 0; i < adatok.Count; i++)
            {
                double szelveny = adatok[i].T13p1 + adatok[i].Ny13p1;
                if (szelveny > 0)
                {
                    osszes.Add(szelveny);
                }
            }
            double osszeg = osszes.Sum();
            double atlag = Math.Round(osszeg / osszes.Count(), 0);
            Console.WriteLine($"5. feladat: Átlag: {atlag} Ft");

            //6. feladat
            Console.WriteLine("6. feladat:");
            int min = 0;
            int max = 0;

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[min].Ny13p1 > adatok[i].Ny13p1 && adatok[i].Ny13p1 != 0)
                {
                    min = i;
                }
                if (adatok[max].Ny13p1 < adatok[i].Ny13p1)
                {
                    max = i;
                }
            }
            Console.WriteLine("\tLegnagyobb:");
            Console.WriteLine($"\tÉv: {adatok[max].Ev}");
            Console.WriteLine($"\tHét: {adatok[max].Het}.");
            Console.WriteLine($"\tForduló: {adatok[max].Fordulo}.");
            Console.WriteLine($"\tTelitalálat: {adatok[max].T13p1} db");
            Console.WriteLine($"\tNyeremény: {adatok[max].Ny13p1} Ft");
            Console.WriteLine($"\tEredmények: {adatok[max].Eredmenyek}");

            Console.WriteLine("\n\tLegkisebb:");
            Console.WriteLine($"\tÉv: {adatok[min].Ev}");
            Console.WriteLine($"\tHét: {adatok[min].Het}.");
            Console.WriteLine($"\tForduló: {adatok[min].Fordulo}.");
            Console.WriteLine($"\tTelitalálat: {adatok[min].T13p1} db");
            Console.WriteLine($"\tNyeremény: {adatok[min].Ny13p1} Ft");
            Console.WriteLine($"\tEredmények: {adatok[min].Eredmenyek}");
            Console.ReadKey();
        }
    }
}
