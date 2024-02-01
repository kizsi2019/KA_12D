using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace karacsonCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napiMunkaLista = new List<NapiMunka>();
            foreach (string sor in File.ReadLines("diszek.txt"))
            {
                napiMunkaLista.Add(new NapiMunka(sor));
            }

            //4.Feladat
            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült");

            //5.Feladat
            bool nemKeszultDisz = false;
            foreach (NapiMunka disz in napiMunkaLista)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    nemKeszultDisz = true;
                    break;
                }
            }
            if (nemKeszultDisz)
            {
                Console.WriteLine("5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült");
            }
            else
            {
                Console.WriteLine("5.feladat: Nem volt olyan nam, amikor egyetlen dísz sem készült");
            }

            //6.Feladat
            Console.WriteLine("6.feladat: ");
            int nap;
            do
            {
                Console.WriteLine("Adja meg a keresett napot [1 ... 40]: ");
                nap = int.Parse(Console.ReadLine());
            } while (nap < 1 || nap > 40);
            int harangok = 0;
            int angyalok = 0;
            int fenyofak = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += napiMunkaLista[i].HarangKesz + napiMunkaLista[i].HarangEladott;
                angyalok += napiMunkaLista[i].AngyalkaKesz + napiMunkaLista[i].AngyalkaEladott;
                fenyofak += napiMunkaLista[i].FenyofaKesz + napiMunkaLista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {nap}, nap végén {harangok} harangok, {angyalok} angyol és {fenyofak} fenyőfa");

            //7.Feladat
            Console.WriteLine("7.feladat: ");
            Dictionary<string, int> eladott = new Dictionary<string, int>();
            eladott.Add("Harang", 0);
            eladott.Add("Angyalka", 0);
            eladott.Add("Fenyöfa", 0);
            foreach (NapiMunka disz in napiMunkaLista)
            {
                eladott["Harang"] -= disz.HarangEladott;
                eladott["Angyalka"] -= disz.AngyalkaEladott;
                eladott["Fenyőfa"] -= disz.FenyofaEladott;
            }
            int max = eladott.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var item in eladott)
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }
            Console.WriteLine();

            //8.Feladat
            StreamWriter sw = new StreamWriter("bevetelek.txt");
            int legalabb10000 = 0;
            foreach (NapiMunka disz in napiMunkaLista) 
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap} : {disz.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon legalább 10000Ft a bevétel");
            sw.Close();

            Console.ReadKey();
        }
    }
}
