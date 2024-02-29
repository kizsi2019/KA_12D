using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace cbradio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<cbClass> adatok = new List<cbClass>();
            foreach (var sor in File.ReadAllLines("cb.txt").Skip(1))
            {
                adatok.Add(new cbClass(sor));
            }
            Console.WriteLine($"3. feladat: Bejegyzések száma: {adatok.Count} db");

            bool talalat = false;
            foreach (var item in adatok)
            {
                if (item.adasDb == 4)
                {
                    talalat = true;
                    break;
                }
            }
            Console.WriteLine($"4. feladat: {(talalat ? "Volt" : "Nem volt")} négy adást indító sofőr.");

            Console.Write("5. feladat: Kérek egy nevet: ");
            string nevbekeres = Console.ReadLine();
            int osszAdasDB = 0;
            
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].nev == nevbekeres)
                {
                    osszAdasDB += adatok[i].adasDb;
                }
            }
            if (osszAdasDB == 0)
            {
                Console.WriteLine("\tNincs ilyen sofőr!");
            }
            else
            {
                Console.WriteLine($"\t{nevbekeres} {osszAdasDB}x használta a CB-rádiót.");
            }

            StreamWriter sw = new StreamWriter("cb2.txt");
            sw.WriteLine("Kezdés;Név;AdasDb");
            for (int i = 0; i < adatok.Count; i++)
            {
                sw.WriteLine(adatok[i].atSzamolPercre() + ";" + adatok[i].nev
                    + ";" + adatok[i].adasDb);
            }
            sw.Close();

            List<string> nevek = new List<string>();
            for (int i = 0; i < adatok.Count; i++)
            {
                if (!nevek.Contains(adatok[i].nev))
                    nevek.Add(adatok[i].nev);
            }
            Console.WriteLine($"8. feladat: Sofőrök száma: {nevek.Count} fő");

            Console.WriteLine("9. feladat: Legtöbb adást indító sofőr");
            int maxAdasDb = adatok[0].adasDb;
            int maxIndex = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].adasDb > maxAdasDb)
                {
                    maxAdasDb = adatok[i].adasDb;
                    maxIndex = i;
                }
            }
            Console.WriteLine($"\tA sofőr neve: {adatok[maxIndex].nev}");
            Console.WriteLine($"\tAdások száma: {maxAdasDb} alkalom");
            Console.ReadKey();
        }
    }
}
