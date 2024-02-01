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
            //2. feladat
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }
            //3. feladat
            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count} fő");
            //4. feladat
            int utolsóÉv = 0;
            foreach (var i in dijazottak)
            {
                if (i.Év > utolsóÉv)
                {
                    utolsóÉv = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: {utolsóÉv}");
            //5. feladat
            Console.Write("5. feladat: Kérem adja meg az ország kódjat: ");
            string inputOrszágKód = Console.ReadLine().ToUpper();
            List <Dijazott> inputOrszágDíjazottjai = new List<Dijazott>();

            foreach (var i in dijazottak )
            {
                if (i.Országkód == inputOrszágKód)
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
            //6. feladat
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
            foreach(var i in stat)
            {
                if(i.Value > 5)
                {
                    Console.WriteLine($"\t{i.Key} - {i.Value} fő");
                }
            }
            //7. feladat
            int elethosszOsszeg = 0;
            int ismertElethosszag = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktivDíjazottakÉletkora = new Elethossz(i.SzületésHalálozás);
                if (aktivDíjazottakÉletkora.IsmertAzElethossz)
                {
                    elethosszOsszeg += aktivDíjazottakÉletkora.ElethosszEvekben;
                    ismertElethosszag++;
                }
            }
            Console.WriteLine($"7. feladat: A kerestt átlag: {(double) elethosszOsszeg / ismertElethosszag:F1} év");
            Console.ReadKey();
        }
    }
}
