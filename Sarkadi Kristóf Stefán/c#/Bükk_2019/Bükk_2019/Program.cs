using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bükk_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.feladat
            List<Versenyzok> versenyzok = new List<Versenyzok>();
            foreach (var sor in File.ReadLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzok(sor));
            }
            Console.WriteLine($"4.Feladat: Versenytázot nem teljesítők: {(1- versenyzok.Count / 691.0)*100}");

            //5.feladat
            int noiVersenyzoRovidzavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzok && v.Tav == "Rövid")
                {
                    noiVersenyzoRovidzavon++;
                }
            }
            Console.WriteLine($"5.feladat: Női versenyzők száma a rövid távú versenyen: {noiVersenyzoRovidzavon} fő.");

            //6.feladat
            bool tobbMintHat = false;
            foreach (var v in versenyzok)
            {
                if (v.tobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }
            Console.WriteLine($"6.feladat: {(tobbMintHat? "volt" : "Nem volt")}ilyen versenyző");

            //7.feladat
            Console.WriteLine("7.feladat: A felnőtt férfi (ff) kategória győztese rövid távon:");
            Versenyzok gyoztesFerfiRovidTav = null;
            foreach (var v in versenyzok)
            {
                if (v.Tav == "Rövid" && v.Kategoria == "ff")
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
            }
            Console.WriteLine($"\tRajtszám: {gyoztesFerfiRovidTav.Rajtszam}");
            Console.WriteLine($"\tNév: {gyoztesFerfiRovidTav.Nev}");
            Console.WriteLine($"\tEgyesület: {gyoztesFerfiRovidTav.Egyesulet}");
            Console.WriteLine($"\tIdő: {gyoztesFerfiRovidTav.Ido}");

            //8.feladat
            Console.WriteLine("8.feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var v in versenyzok)
            {
                if (!v.NoiVersenyzok)
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
                Console.WriteLine($"\t{s.Key} - {s.Value}");
            }







            Console.ReadKey();
        }
    }
}
