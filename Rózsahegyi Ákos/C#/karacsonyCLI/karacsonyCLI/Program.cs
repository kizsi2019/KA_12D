using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. feladat
            List<NapiMunka> diszekLista = new List<NapiMunka>();
            foreach (var sor in File.ReadAllLines("diszek.txt")) 
            {
                diszekLista.Add(new NapiMunka(sor));
            }
            //4. feladat
            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült.");

            //5. feladat
            bool nemKeszult = false;
            foreach (NapiMunka item in diszekLista)
            {
                if (item.HarangKesz == 0 && item.AngyalkaKesz == 0 && item.FenyofaKesz == 0)
                {
                    nemKeszult = true;
                    break;
                }
            }
            if (nemKeszult)
            {
                Console.WriteLine("\n5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült");
            }
            else
            {
                Console.WriteLine("5.feladat: Nem volt olyan nap, amikor egyetlen dísz sem készült");
            }

            //6. feladat
            Console.WriteLine("\n6.feladat:");
            int nap;

            do
            {
                Console.Write("Adja meg a keresett napot [1 ... 40]: ");
                nap = int.Parse(Console.ReadLine());
            } while (nap < 1 || nap > 40);

            int harangok = 0;
            int angyalkak = 0;
            int fenyofak = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += diszekLista[i].HarangKesz + diszekLista[i].HarangEladott;
                angyalkak += diszekLista[i].AngyalkaKesz + diszekLista[i].AngyalkaEladott;
                fenyofak += diszekLista[i].FenyofaKesz + diszekLista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {nap}. nap végén {harangok} harang, {angyalkak} angyalka és {fenyofak} fenyőfa maradt készleten.");
            
            //7. feladat
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyal", 0);
            eladottak.Add("Fenyőfa", 0);

            foreach (NapiMunka item in diszekLista)
            {
                eladottak["Harang"] -= item.HarangEladott;
                eladottak["Angyal"] -= item.AngyalkaEladott;
                eladottak["Fenyőfa"] -= item.FenyofaEladott;
            }
            int max = eladottak.Values.Max();
            Console.WriteLine($"\n7.feladat: Legtöbbet eladott dísz: {max} darab");
            foreach (var item in eladottak)
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }

            //8. feladat
            StreamWriter sw = new StreamWriter("bevetel.txt");
            int tizezer = 0;

            foreach (NapiMunka disz in diszekLista)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap}:{disz.NapiBevetel()}");
                    tizezer++;
                }
            }
            sw.WriteLine($"{tizezer} napon volt legalább 10000 Ft a bevétel.\n");
            sw.Close();
            Console.ReadKey();
        }
    }
}
