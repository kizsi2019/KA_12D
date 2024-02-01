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
            List<NapiMunka> napiMunkas = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkas.Add(new NapiMunka(sor));
            }
            Console.WriteLine($"4. feladat: Összesen {NapiMunka.KeszultDb} darab készült el.");
            bool nemdb = false;
            foreach (NapiMunka disz in napiMunkas)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz == 0 && disz.FenyofaKesz == 0)
                {
                    nemdb = true;
                    break;
                }
            }
            if (nemdb)
            {
                Console.WriteLine("5. feladat: Volt olyan nap amikor egy dísz sem készült.");
            }
            else
            {
                Console.WriteLine("5. feladat: Nem volt olyan nap amikor egy dísz sem készült.");
            }
            //6
            Console.WriteLine("6. feladat");
            int nap;
            do
            {
                Console.Write("Adja meg a keresett napot [1...40]");
                nap = int.Parse(Console.ReadLine());
            }
            while (nap < 1 || nap > 40);
            int harangok = 0;
            int angyalok = 0;
            int fenyofadiszek = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok = napiMunkas[i].HarangKesz + napiMunkas[i].HarangEladott;
                angyalok = napiMunkas[i].AngyalkaKesz + napiMunkas[i].AngyalkaEladott;
                fenyofadiszek = napiMunkas[i].FenyofaKesz + napiMunkas[i].FenyofaEladott;
            }
            Console.WriteLine($"A(z) {nap}. nap végén {harangok} harang, {angyalok} angyal, {fenyofadiszek} fenyőfadíszek");
            Console.WriteLine("7. feladat: legtöbb készült db.");
            Dictionary<string, int> eladott = new Dictionary<string, int>();
            eladott.Add("Harang", 0);
            eladott.Add("Angyalka", 0);
            eladott.Add("Fenyőfadísz", 0);
            foreach (NapiMunka disz in napiMunkas)
            {
                eladott["Harang"] -= disz.HarangEladott;
                eladott["Angyalka"] -= disz.HarangEladott;
                eladott["Fenyőfadísz"] -= disz.HarangEladott;
            }
            int max = eladott.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var item  in eladott)
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }
            Console.WriteLine();
            //8
            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legala10000 = 0;
            foreach (NapiMunka disz in napiMunkas)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap} : {disz.NapiBevetel()}");
                    legala10000++;
                }
            }
            sw.WriteLine($"{legala10000} napon legakább 10000 ft a bevétel");
            sw.Close();
            Console.ReadKey();
        }
    }
}