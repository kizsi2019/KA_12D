using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrvosiNobelDijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }
            // 3. feladat
            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count} fő");

            // 4. feladat
            int utolsóÉv = dijazottak.First().Év;
            foreach (var i in dijazottak)
            {
                if (i.Év > utolsóÉv)
                {
                    utolsóÉv = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: {utolsóÉv}");

            // 5. feladat
            Console.WriteLine("5. feladat: Kérem adja meg az ország kódját: ");
            string inputOrszágkód = Console.ReadLine().ToUpper();
            List<Dijazott> inputOrszágDíjazottjai = new List<Dijazott>();

            foreach (var i in dijazottak )
            {
                if (i.Országkód == inputOrszágkód)
                {
                    inputOrszágDíjazottjai.Add(i);
                }
            }
            if (inputOrszágDíjazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott");
            }
            if (inputOrszágDíjazottjai.Count == 1)
            {
                Console.WriteLine($"A megadott ország díjazottjai:");
                Console.WriteLine($"\tNév: {inputOrszágDíjazottjai.First().Név}");
                Console.WriteLine($"\tÉv: {inputOrszágDíjazottjai.First().Év}");
                Console.WriteLine($"\tSz/H: {inputOrszágDíjazottjai.First().SzületésHalálozás}");


            }
            if (inputOrszágDíjazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszágDíjazottjai.Count} fő díjazott volt");
            }

            // 6. feladat
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in dijazottak)
            {
                if (stat.ContainsKey(i.Országkód))
                {
                    stat[i.Országkód]++;
                }
                else
                {
                    stat.Add(i.Országkód, 1);
                }
            }
            foreach (var i in stat)
            {
                if (i.Value > 5)
                {
                    Console.WriteLine($"\t{i.Key} - {i.Value} fő"); 
                }
            }
            // 7. feladat
            int élethosszÖsszeg = 0;
            int ismertÉlethosszFő = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktivDijazottakÉletkora = new Elethossz(i.SzületésHalálozás);
                if (aktivDijazottakÉletkora.IsmertAzElethossz)
                {
                    élethosszÖsszeg += aktivDijazottakÉletkora.ElethosszEvekben;
                    ismertÉlethosszFő++;
                }
            }
            Console.WriteLine($"7.feladat: A keresett átlag: {(double)élethosszÖsszeg / ismertÉlethosszFő:F1} év");

            Console.ReadKey();   
                
        }
    }
}
