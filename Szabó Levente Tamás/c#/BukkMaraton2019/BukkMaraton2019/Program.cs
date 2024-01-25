using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bukkmaraton2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Feladat
            List<versenyzo> versenyzok = new List<versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new versenyzo(sor));
            }
            Console.WriteLine($"4. feladat: Versenytávot nem teljesító {(1 - versenyzok.Count / 691.0) * 100}%");
            // 5. feladat
            int noiVersenyzoRovidTavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
            }
            Console.WriteLine($"$5. feladat: Női versenyzők száma a rövid távú versenyen: {noiVersenyzoRovidTavon} fő.");
            // 6. feladat
            bool tobbMintHat = false;
            foreach (var v in versenyzok)
            {
                if (v.TobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }
            Console.WriteLine($"6. feladat: {(tobbMintHat ? "Volt" : "Nem volt")} ilyen versenyzo");
            // 7. feladat
            Console.WriteLine("7. feladat: A felnőtt férfi (ff) kategória győztese rövid távon");
            versenyzo gyoztesFerfiRovidTav = null;
            foreach (var v in versenyzok)
            {
                if (gyoztesFerfiRovidTav == null)
                {
                    gyoztesFerfiRovidTav = v;
                }
                else
                {
                    if (v.Ido < gyoztesFerfiRovidTav.Ido)
                    {
                        gyoztesFerfiRovidTav = v;
                    }
                }
            }
            Console.WriteLine($"\tRajtszám: {gyoztesFerfiRovidTav.Rajtszam}");
            Console.WriteLine($"\tNév: {gyoztesFerfiRovidTav.nev}");
            Console.WriteLine($"\tEgyesület: {gyoztesFerfiRovidTav.Egyesulet}");
            Console.WriteLine($"\tIdő: {gyoztesFerfiRovidTav.Ido}");
            // 8. feladat
            Console.WriteLine("8. feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var v in versenyzok)
            {
                if (!v.NoiVersenyzo)
                {
                    if (stat.ContainsKey(v.Kategoria))
                    {
                        stat[v.Kategoria]++;
                    }
                    else
                    {
                        stat.Add(v.Kategoria, 1);
                    }
                }
            }
            foreach (var s in stat)
            {
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}