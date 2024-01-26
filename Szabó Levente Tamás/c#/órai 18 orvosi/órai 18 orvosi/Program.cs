using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_18_orvosi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2
            List<Díjazott> díjazottak = new List<Díjazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                díjazottak.Add(new Díjazott(i));
            }
            //3
            Console.WriteLine($"3. feladat: A díjazottak száma: {díjazottak.Count} fő");
            //4
            int utolsóÉv = díjazottak.First().Év;
            foreach (var i in díjazottak)
            {
                if (i.Év > utolsóÉv)
                {
                    utolsóÉv = i.Év;
                }
            }
            Console.WriteLine($"4. feladat {utolsóÉv}");
            //5
            string inputOrszágKód = Console.ReadLine().ToUpper();
            List<Díjazott> inputOrszágDíjazottjai = new List<Díjazott>();
            foreach (var i in díjazottak)
                if (i.Országkód == inputOrszágKód)
                {
                    inputOrszágDíjazottjai.Add(i);
                }
            if (inputOrszágDíjazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott");
            }
            if (inputOrszágDíjazottjai.Count == 1)
            {
                Console.WriteLine("\tA megadott ország díjazottjai");
                Console.WriteLine($"\tNév: {inputOrszágDíjazottjai.First().Név}");
                Console.WriteLine($"\tÉv: {inputOrszágDíjazottjai.First().Év}");
                Console.WriteLine($"\tSz/H: {inputOrszágDíjazottjai.First().SzületésHalálozás}");
            }
            if (inputOrszágDíjazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszágDíjazottjai.Count} fő díjazott volt");
            }
            //6
            Console.WriteLine("6. feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in díjazottak)
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
            //7
            int élethosszÖsszeg = 0;
            int ismertÉlethosszFő = 0;
            int aktivDíjazottakÉletkora = 0;
            foreach (var i in díjazottak)
            {
                Elethosz = aktivDíjazottakÉletkora = new Elethosz(i.SzületésHalálozás);
                if (aktivDíjazottakÉletkora.IsmertAzElethossz)
                {
                    élethosszÖsszeg += aktivDíjazottakÉletkora.ElethosszEvekben;
                    ismertÉlethosszFő++;
                }
            }
            Console.ReadKey();
        }
    }
}
