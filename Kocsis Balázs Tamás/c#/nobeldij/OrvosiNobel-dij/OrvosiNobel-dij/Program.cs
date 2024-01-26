using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrvosiNobel_dij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }

            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count} fő");

            int utolsoEv = dijazottak.First().Év;
            foreach (var i in dijazottak)
            {
                if (i.Év > utolsoEv)
                {
                    utolsoEv = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: Az utolsó év: {utolsoEv}");

            Console.WriteLine("5.feladat: Kérem adja meg az országkódot: ");
            string orszagkod = Console.ReadLine().ToUpper();
            List<Dijazott> egyorszag = new List<Dijazott>();
            foreach (var i in dijazottak)
            {
                if (i.Országkód == orszagkod)
                {
                    egyorszag.Add(i);
                }
                
            }
            if (egyorszag.Count == 0)
            {
                Console.WriteLine("\tEbben az országban nem volt díjazott");
            }
            if (egyorszag.Count == 1)
            {
                Console.WriteLine($"A megadott ország díjazottjai: ");
                Console.WriteLine($"\tNév: {egyorszag.First().Név} ");
                Console.WriteLine($"\tÉv: {egyorszag.First().Év} ");
                Console.WriteLine($"\tSz/H: {egyorszag.First().SzületésHalálozás} ");
            }
            if (egyorszag.Count > 1)
            {
                Console.WriteLine($"A megadott országból {egyorszag.Count} díjazott volt");
            }

            Console.WriteLine("6.feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var v in dijazottak)
            {
                if (stat.ContainsKey(v.Országkód))
                {
                    stat[v.Országkód]++;
                }
                else
                {
                    stat.Add(v.Országkód, 1);
                }
            }
            foreach (var v in stat)
            {
                if (v.Value > 5)
                {
                    Console.WriteLine($"\t{v.Key} - {v.Value}");
                }
            }

            int elethosszOsszeg = 0;
            int ismertElethosszFo = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktivDijazottakEletkora = new Elethossz(i.SzületésHalálozás);
                if (aktivDijazottakEletkora.IsmertAzElethossz)
                {
                    elethosszOsszeg += aktivDijazottakEletkora.ElethosszEvekben;
                    ismertElethosszFo++;
                }
            }
            Console.WriteLine($"7. feladat: A keresett átlag {(double) elethosszOsszeg / ismertElethosszFo:F1} év");































            Console.ReadKey();
        }
    }
}
