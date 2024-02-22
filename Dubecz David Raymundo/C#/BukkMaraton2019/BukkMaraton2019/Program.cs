using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BukkMaraton2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. feladat
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");
            int noiVersenyzoRovidTavon = 0;
            foreach (var item in versenyzok)
            {
                if (item.NoiVersenyzo && item.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
            }
            Console.WriteLine($"5. feladat: noi versenyzok szama:  {noiVersenyzoRovidTavon}fo");
            bool tobbminthat = false;

            foreach (var item in versenyzok)
            {
                if (item.TobbMintHat)
                {
                    tobbminthat = true;
                    break;
                }
            }
            Console.WriteLine($"6. feladat: {(tobbminthat ? "Volt" : "Nem volt")} ilyen versenyzo");
            Versenyzo gyoztesFerfiRovidtTav = null;
            foreach (var item in versenyzok)
            {
                if (item.Tav == "Rövid" && item.Kategoria == "ff")
                {
                    if (gyoztesFerfiRovidtTav == null)
                    {
                        gyoztesFerfiRovidtTav = item;
                    }
                    else
                    {
                        if (item.Ido < gyoztesFerfiRovidtTav.Ido)
                        {
                            gyoztesFerfiRovidtTav = item;
                        }
                    }
                }
            }
            Console.WriteLine($"8. feladat: Stats");
            Console.WriteLine($"7. feladat: \t\n\tNev: {gyoztesFerfiRovidtTav.Nev}");
            Console.WriteLine($" \tRajtszam: {gyoztesFerfiRovidtTav.Rajtszam}");
            Console.WriteLine($": \tEgyesulet: {gyoztesFerfiRovidtTav.Egyesulet}");
            Console.WriteLine($" \tIdo: {gyoztesFerfiRovidtTav.Ido}");
            Console.WriteLine($"6. feladat: {(tobbminthat ? "volt" : "nemvolt")} ilyen versenyzo");
            Console.WriteLine($"5. feladat: Noi versenyzok rovid tavon: {noiVersenyzoRovidTavon}fo ");

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
                Console.WriteLine($"\t{item.Key} - {item.Value}fo");
            }
            Console.ReadKey();
        }
    }
}