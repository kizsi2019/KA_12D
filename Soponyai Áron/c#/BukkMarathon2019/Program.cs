using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace BukkMaraton2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. feladat
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            // 4. feladat
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");

            // 5. feladat
            int noiVersenyzoRovidTavon = 0;
            foreach (var item in versenyzok)
            {
                if (item.NoiVersenyzo && item.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
            }
            Console.WriteLine($"5. feladat: Női versenyzők száma rövid távú versenyen: {noiVersenyzoRovidTavon} fő");

            // 6. feladat
            bool tobbMintHat = false;
            foreach (var item in versenyzok)
            {
                if (item.TobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }
            Console.WriteLine($"6. feladat: {(tobbMintHat ? "Volt" : "Nem volt")} ilyen versenyző");

            // 7. feladat
            Console.WriteLine($"7. feladat: A felnőtt férfi (ff) kategória győztese rövid távon");
            Versenyzo gyoztesFelnottFerfiRovidTav = null;
            foreach (var item in versenyzok)
            {
                if (item.Tav == "Rövid" && item.Kategoria == "ff")
                {
                    if (gyoztesFelnottFerfiRovidTav == null)
                    {
                        gyoztesFelnottFerfiRovidTav = item;
                    }
                    else
                    {
                        if (item.Ido < gyoztesFelnottFerfiRovidTav.Ido)
                        {
                            gyoztesFelnottFerfiRovidTav = item;
                        }
                    }
                }
            }
            Console.WriteLine($"\tRajtszám: {gyoztesFelnottFerfiRovidTav.Rajtszam}");
            Console.WriteLine($"\tNév: {gyoztesFelnottFerfiRovidTav.Nev}");
            Console.WriteLine($"\tEgyesület: {gyoztesFelnottFerfiRovidTav.Egyesulet}");
            Console.WriteLine($"\tIdő: {gyoztesFelnottFerfiRovidTav.Ido}");

            // 8.feladat
            Console.WriteLine("8. feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var item in versenyzok)
            {
                if (!item.NoiVersenyzo)
                {
                    if (stat.ContainsKey(item.Kategoria))
                    {
                        stat[item.Kategoria]++;
                    }
                    else
                    {
                        stat.Add(item.Kategoria, 1);
                    }
                }
            }
            foreach (var item in stat)
            {
                Console.WriteLine($"\t{item.Key} - {item.Value}fő");
            }
            Console.ReadKey();
        }
    }
}
