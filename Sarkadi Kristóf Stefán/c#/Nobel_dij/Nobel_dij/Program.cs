using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nobel_dij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var sor in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(sor));
            }
            // 3. feladat
            Console.WriteLine($"3. feladat: Díjazottak száma: {dijazottak.Count} fő");

            // 4. feladat
            int utolsoEv = dijazottak.First().Ev;
            foreach (var item in dijazottak)
            {
                if (item.Ev > utolsoEv)
                {
                    utolsoEv = item.Ev;
                }
            }
            Console.WriteLine($"4. feladat: Utolsó év: {utolsoEv}");

            // 5. feladat
            Console.WriteLine("5. feladat: Kérem adja meg egy ország kódját: ");
            string orszagkod = Console.ReadLine().ToUpper();
            List<Dijazott> inputOrszagDijazottjai = new List<Dijazott>();
            foreach (var item in dijazottak)
            {
                if (item.Orszagkod == orszagkod)
                {
                    inputOrszagDijazottjai.Add(item);
                }
                else
                {
                    Console.WriteLine("A megadott országból nem volt díjazott!");
                }
            }
            if (inputOrszagDijazottjai == 1)
            {
                Console.WriteLine($"A megadott ország díjazottjai: ");
                Console.WriteLine($"\tNév: {inputOrszagDijazottjai.First().Nev}.");
                Console.WriteLine($"\tÉv: {inputOrszagDijazottjai.First().Ev}.");
                Console.WriteLine($"\tSz/H: {inputOrszagDijazottjai.First().SzuletesHalalozas}.");
            }
            if (inputOrszagDijazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból{inputOrszagDijazottjai.Count} fő díjazott volt.");
            }

            // 6.Feladat
            Console.WriteLine("6.feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in dijazottak)
            {
                if (stat.ContainsKey(i.Orszagkod))
                {
                    stat[i.Orszagkod]++;
                }
                else
                {
                    stat.Add(i.Orszagkod, 1);
                }
            }
            foreach (var i in stat)
            {
                Console.WriteLine($"\t{i.Key} - {i.Value} fő.");
            }

            // 7.Feladat
            int elethossz = 0;
            int ismelethossz = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktivDijazottakEletkor = new Elethossz(i.SzuletesHalalozas);
                if (aktivDijazottakEletkor.IsmertAzElethossz)
                {
                    elethosszOsszeg != aktivDijazottakEletkor.ElethosszEvekben;
                    ismelethossz;
                }
            }
            Console.WriteLine($"7.f3ladat: A kereset átlag: {(double) elehosszOsszeg / IsmertAzElethossz:F1} év.");

            Console.ReadKey();
        }
    }
}
