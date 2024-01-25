using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok
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
            Console.Write("5. feladat: Kérem adja meg egy ország kódját: ");
            string orszagkod = Console.ReadLine().ToUpper();
            List<Dijazott> orszagDijazottjai = new List<Dijazott>();
            foreach (var item in dijazottak)
            {
                if (item.Orszagkod == orszagkod)
                {
                    orszagDijazottjai.Add(item);
                }
            }
            if (orszagDijazottjai.Count == 0)
            {
                Console.WriteLine("A megadott országból nem volt díjazott!");
            }
            if (orszagDijazottjai.Count == 1)
            {
                Console.WriteLine($"\tA megadott ország díjazottja:");
                Console.WriteLine($"\tNév: {orszagDijazottjai.First().Nev}");
                Console.WriteLine($"\tÉv: {orszagDijazottjai.First().Ev}");
                Console.WriteLine($"\tSz/H: {orszagDijazottjai.First().SzuletesHalalozas}");
            }
            if (orszagDijazottjai.Count > 1)
            {
                Console.WriteLine($"A megadott országból {orszagDijazottjai.Count} fő díjazott volt!");
            }

            // 6. feladat
            Console.WriteLine("6. Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var item in dijazottak)
            {
                if (stat.ContainsKey(item.Orszagkod))
                {
                    stat[item.Orszagkod]++;
                }
                else
                {
                    stat.Add(item.Orszagkod, 1);
                }
            }
            foreach (var item in stat)
            {
                if (item.Value > 5)
                {
                    Console.WriteLine($"\t{item.Key} - {item.Value} fő");
                }
            }

            // 7. feladat
            int elethosszOsszeg = 0;
            int ismertElethosszFo = 0;
            foreach (var item in dijazottak)
            {
                Elethossz aktivDijazottakEletkora = new Elethossz(item.SzuletesHalalozas);
                if (aktivDijazottakEletkora.IsmertAzElethossz)
                {
                    elethosszOsszeg += aktivDijazottakEletkora.ElethosszEvekben;
                    ismertElethosszFo++;
                }
            }
            Console.WriteLine($"7. feladat: A keresett átlag: {((1.0 * elethosszOsszeg) / ismertElethosszFo):f1} év");
            Console.ReadKey();
        }
    }
}
