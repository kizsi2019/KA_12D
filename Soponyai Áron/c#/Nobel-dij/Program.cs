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
            List<dijazott> dijazottak = new List<dijazott>();
            foreach (var sor in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new dijazott(sor));
            }
            //feladat 3
            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count} fő.");

            //feladat 4
            int utolsóÉv = dijazottak.First().Év;

            foreach (var i in dijazottak)
            {
                if (i.Év > utolsóÉv)
                {
                    utolsóÉv = i.Év;
                }
            }
            Console.WriteLine($"4.feladat: {utolsóÉv} az utolsó év.");

            //5 feladat

            string inputorszagkod = Console.ReadLine().ToUpper();
            List<dijazott> inputorszagkodd = new List<dijazott>();

            foreach (var j in dijazottak)
            {
                if (j.Országkód == inputorszagkod)
                {
                    inputorszagkodd.Add(j);
                }
            }
            if (inputorszagkodd.Count == 0) 
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott");
            }
            if (inputorszagkodd.Count == 1)
            {
                Console.WriteLine("\tA megadott ország díjazottja:");
                Console.WriteLine($"\tNév: {inputorszagkodd.First().Név}");
                Console.WriteLine($"\tÉv: {inputorszagkodd.First().Év}");
                Console.WriteLine($"\tSz/H: {inputorszagkodd.First().SzületésHalálozás}");

            }
            if (inputorszagkodd.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputorszagkodd.Count} fő ből díjazott volt");
            }

            //6 feladat
            Console.WriteLine("6. Feladat:");
            Dictionary<string, int> stat = new Dictionary<string, int>();

            foreach( var k in dijazottak)
            {
                if (stat.ContainsKey(k.Országkód))
                {
                    stat[k.Országkód]++;
                }
                else
                {
                    stat.Add(k.Országkód, 1);
                }
            }
            foreach (var i in stat)
            {
                if (i.Value > 5)
                {
                    Console.WriteLine($"\t{i.Key} - {i.Value} fő");
                }
            }
            //7 feladat

            int élethosszosszeg = 0;
            int ismerthosszfő = 0;
            foreach ( var i in dijazottak)
            {
                Elethossz aktivdijelethossz = new Elethossz(i.SzületésHalálozás);
                if (aktivdijelethossz.IsmertAzElethossz)
                {
                    élethosszosszeg += aktivdijelethossz.ElethosszEvekben;
                    ismerthosszfő++;
                }
            }

            Console.WriteLine($"7. feladat: A keresett átlag: {(double) élethosszosszeg/ ismerthosszfő:F1} év");


            Console.ReadKey();
        }
    }
}
