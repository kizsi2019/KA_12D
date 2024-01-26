using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelDíj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            List<Díjazott> dijazottak = new List<Díjazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Díjazott(i));
            }
            //3. feladat
            Console.WriteLine($"3. feladat: A dijazottak szama: {dijazottak.Count} fő");
            //4. feladat
            int utso = dijazottak.First().Év;
            foreach (var i in dijazottak)
            {
                if (i.Év > utso)
                {
                    utso = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: {utso} legfrissebb ev");
            //5. feladat
            Console.WriteLine("Add meg az ország kodjat:");
            Console.ReadLine();

            string b = Console.ReadLine().ToUpper();

            List<Díjazott> inputOrszágDijazottjai = new List<Díjazott>();
            foreach (var i in dijazottak)
            {
                if (i.Országkód == b)
                {
                    inputOrszágDijazottjai.Add(i);
                }
            }
            if (inputOrszágDijazottjai.Count ==0)
            {
                Console.WriteLine($" nincs díjazott");
            }
            if (inputOrszágDijazottjai.Count == 1)
            {
                Console.WriteLine($"A megadott ország díjazottjai: ");
                Console.WriteLine($"\t Nev : {inputOrszágDijazottjai.First().Név}");
                Console.WriteLine($"\t Év : {inputOrszágDijazottjai.First().Év}");
                Console.WriteLine($"\t Sz/H : {inputOrszágDijazottjai.First().SzületésHalálozás}");
            }
            if (inputOrszágDijazottjai.Count > 0) 
            {
                Console.WriteLine($"\t A megadott ország nyertesei: {inputOrszágDijazottjai.Count} Száma");
            }
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach ( var i in dijazottak)
            {
                if(stat.ContainsKey(i.Országkód))
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
                if (i.Value>5)
                {
                    Console.WriteLine($"\t{i.Key} - {i.Value}");
                }
            }

            int élethosszÖsszeg = 0;
            int ismertÉletHossz = 0;
            foreach (var i in dijazottak)
            {
                Elethossz aktivDijazottakÉletkora = new Elethossz(i.SzületésHalálozás);
                if ( aktivDijazottakÉletkora.IsmertAzElethossz)
                {
                    élethosszÖsszeg+= aktivDijazottakÉletkora.ElethosszEvekben;
                    ismertÉletHossz++;
                }
            }
            Console.WriteLine($"keresett átlag: {(double)élethosszÖsszeg/ismertÉletHossz:F1} év");




























































            Console.WriteLine("Tourettem van ahahahahhahah nigger hahaha");
            Console.ReadKey();
        }
    }
}

