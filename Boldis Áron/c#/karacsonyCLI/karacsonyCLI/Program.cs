using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napiMunkaLista  = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkaLista.Add(new NapiMunka(sor));
            }
            //4. feladat
            Console.WriteLine($"4. feladat: Összesen {NapiMunka.KeszultDb} db dísz készült el.");

            //5. feladat
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
                Console.WriteLine("5. feladat. Volt olyan nap amikor egyetlen disz sem keszült");
            }
            else
            {
                Console.WriteLine("5. feladat: Nem volt olyan nap amikor gyetlen dísz sem készült.");
            }

            //6. feladat
            Console.WriteLine("6. feladat");
            int nap;
            do
            {
                Console.Write("Adja meg a keresett napot [1...40]: ");
                nap = int.Parse(Console.ReadLine());
            }while(nap < 1 || nap > 40);
            int harangok = 0;
            int angyalok = 0;
            int fenyofaDiszek = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += napiMunkaLista[i].HarangKesz + napiMunkaLista[i].HarangEladott;
                angyalok += napiMunkaLista[i].AngyalkaKesz + napiMunkaLista[i].AngyalkaEladott;
                fenyofaDiszek += napiMunkaLista[i].FenyofaKesz + napiMunkaLista[i].FenyofaEladott;
            }
            Console.WriteLine($"A(z) {nap}. nap végén {harangok} harang, {angyalok} angyal, {fenyofaDiszek} fenyőfa maradt készleten");
            Console.WriteLine("7. feladat: a legtöbbet eladott disz: ");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyofa", 0);
            foreach(NapiMunka disz in napiMunkaLista)
            {
                eladottak["Harang"] -= disz.HarangEladott;
                eladottak["Angyalka"] -= disz.AngyalkaEladott;
                eladottak["Fenyofa"] -= disz.FenyofaEladott;
            }
            int max = eladottak.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var item in eladottak)
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }

            Console.WriteLine();
            //8. feladat
            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb10000 = 0;
            foreach (NapiMunka disz in napiMunkaLista)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap} : {disz.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon legalabb 10000 Ft a bevétel");
            sw.Close();

            Console.ReadKey(); 
        }
       

    }
}
