using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            List<Dijazott> dijazottak = new List<Dijazott>();
             foreach (var i  in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }
            //3. feladat 
            Console.WriteLine( $"3. feladat: A dijazottak szama: {dijazottak.Count} fő");
            //4. feladat
            int utso = dijazottak.First().Év;
            foreach (var i in dijazottak) 
            {
                if (i.Év >utso) 
                {
                    utso = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: {utso} legfrissebb ev");
            //5. feladat
            Console.WriteLine("Add meg az ország kodjat:");
            string k = Console.ReadLine();
            List<Dijazott> inputOrszágDijazottjai = new List<Dijazott>();
            foreach (var i in dijazottak)
            {
                if (i.Országkód == k)
                {
                    inputOrszágDijazottjai.Add(i);
                }

            }
            if (inputOrszágDijazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott orszagbol nem volt dijazott");
            }
            if (inputOrszágDijazottjai.Count == 1)
            {
                Console.WriteLine($"A megadott orszag dijazottjai:");
                Console.WriteLine($"\tNev:{inputOrszágDijazottjai.First().Név}");
                Console.WriteLine($"\tÉv{inputOrszágDijazottjai.First().Év}");
                Console.WriteLine($"\tSz/H:{inputOrszágDijazottjai.First().SzületésHalálozás}");
            }
            if (inputOrszágDijazottjai.Count > 1)
            {
                Console.WriteLine($"A megadott orszagbol {inputOrszágDijazottjai.Count} fo dijazott volt");
            }
            //6. feladat
            Dictionary<string, int> dik = new Dictionary<string, int>();
            foreach ( var i in dijazottak)
            {
                if (dik.ContainsKey(i.Országkód))
                {
                    dik[i.Országkód]++;
                }
                else
                {
                    dik.Add(i.Országkód, 1);
                }
            }
            foreach (var i in dik)
            {
                if (i.Value > 5)
                {
                    Console.WriteLine($"\t{i.Key} - {i.Value}");
                }
            }
            //7. feladat
            int elethosszOsszeg = 0;
            int ismertElethosszFo = 0;
            foreach ( var i in dijazottak) 
            {
                Elethossz aktivDijazottakEletkora = new Elethossz(i.SzületésHalálozás);
                if (aktivDijazottakEletkora.IsmertAzElethossz)
                {
                    elethosszOsszeg += aktivDijazottakEletkora.ElethosszEvekben;
                    ismertElethosszFo++;
                }
            }
            Console.WriteLine($"7. feladat: A keresett atlag : {(double)elethosszOsszeg/ismertElethosszFo:F1} ev");













            Console.ReadKey();









        }
    }
}
