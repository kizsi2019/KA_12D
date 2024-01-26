using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nobel
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
            Console.WriteLine($"3. feladat: A dijazottak száma: {dijazottak.Count}fő ");
            int utolsóÉv = dijazottak.First().Év;
            foreach (var i in dijazottak)
            {
                if (i.Év > utolsóÉv)
                {
                    utolsóÉv = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: {utolsóÉv} legfrissebb év");
            Console.WriteLine("5.feladat: Add meg az ország kódját: ");
            string inputOrszágKód = Console.ReadLine().ToUpper();
            List<Dijazott> inputOrszágKódDijazottjai = new List<Dijazott>();
            foreach (var i in dijazottak)
            {
                if (i.Országkód == inputOrszágKód)
                {
                    inputOrszágKódDijazottjai.Add(i);
                }
                
            }
            if (inputOrszágKódDijazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt dijazott");
            }
            if (inputOrszágKódDijazottjai.Count == 1)
            {
                Console.WriteLine($"A megadott ország dijazottjai:");
                Console.WriteLine($"\tNév: {inputOrszágKódDijazottjai.First().Név}");
                Console.WriteLine($"\tÉv: {inputOrszágKódDijazottjai.First().Év}");
                Console.WriteLine($"\tSz/H: {inputOrszágKódDijazottjai.First().SzületésHalálozás}");
            }
            if (inputOrszágKódDijazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszágKódDijazottjai.Count} fő dijazott volt");
            }
            Console.WriteLine($"6.feladat Statisztika");
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
                    Console.WriteLine($"\t{i.Value}-{i.Value} fő");
                }
            }
            int élethosszÖsszeg = 0;
            int ismertÉlethosszFő = 0;
            foreach (var i in dijazottak)
            {
                elethossz aktivDijazottakÉletkora = new elethossz(i.SzületésHalálozás);
                if (aktivDijazottakÉletkora.IsmertAzElethossz)
                {
                    élethosszÖsszeg += aktivDijazottakÉletkora.ElethosszEvekben;
                    ismertÉlethosszFő++;
                }
            }
            Console.WriteLine($"7.feladat: A keresett átlag:{(double)élethosszÖsszeg/ismertÉlethosszFő:F1} év");

            Console.ReadKey();
        }
    }
}
