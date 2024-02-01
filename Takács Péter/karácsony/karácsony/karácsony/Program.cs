using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;

namespace karácsony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka>  napiMunkalista= new List<NapiMunka>();
            foreach(string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkalista.Add(new NapiMunka(sor));
            }
            Console.WriteLine($"4. feladat összesen {NapiMunka.KeszultDb} darab dísz készült el");

            //5
            bool nemKeszultDisz = false;
            foreach (NapiMunka disz in napiMunkalista)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    nemKeszultDisz = true;
                    break;
                }
            }
            if(nemKeszultDisz)
            {
                Console.WriteLine("5. feladat Volt olyan nap amikor egyetlen disz sem készült");
            }
            else
            {
                Console.WriteLine("5. feladat Nem volt olyan nap amikor egy disz sem készült. ");
            }
            //6 
            Console.WriteLine("6.feladat");
            int nap;
            do
            {
                Console.Write("Adja meg a keresett napot [1....40]: ");
                nap = int.Parse(Console.ReadLine());
            }while (nap < 1 || nap > 40);
            int harangok = 0;
            int angyalok = 0;
            int fenyofaDiszek = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok = napiMunkalista[i].HarangKesz + napiMunkalista[i].HarangEladott;
                angyalok = napiMunkalista[i].AngyalkaKesz + napiMunkalista[i].AngyalkaEladott;
                fenyofaDiszek = napiMunkalista[i].FenyofaKesz + napiMunkalista[i].FenyofaEladott;

            }
            Console.WriteLine($"A(z) {nap}. nap végén {harangok} harang, {angyalok} angyal, {fenyofaDiszek} fenyofa maradt készleten. ");
            //7
            Console.WriteLine("7. feladat: a legtöbbet eladott disz: ");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyofa", 0);
            foreach (var disz in napiMunkalista)
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
            //8
            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb10000 = 0;
            foreach(NapiMunka disz in napiMunkalista)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap} : {disz.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon legalább 10000ft a bevétel");
            sw.Close();
            Console.ReadKey();
        }
    }
}
