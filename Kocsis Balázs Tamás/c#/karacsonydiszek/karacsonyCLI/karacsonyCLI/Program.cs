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
            List<NapiMunka> np = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                np.Add(new NapiMunka(sor));
            }
            Console.WriteLine($"4. feladat: A hölgy {NapiMunka.KeszDb}db díszt készített");
            bool NemKeszult = false;
            foreach (NapiMunka disz in np)
            {
                if (disz.KeszH == 0 && disz.KeszF == 0 && disz.KeszA == 0)
                {
                    NemKeszult = true;
                    break;
                }
            }
            if (NemKeszult)
            {
                Console.WriteLine("5.feladat: Volt nap amikor nem készült dísz");
            }
            else
            {
                Console.WriteLine("5.feladat: Nem volt nap amikor nem készült dísz");
            }

            Console.WriteLine("6.feladat:");
            int nap;
            do
            {
                Console.Write("Kérem a keresett napot 1-40 közt: ");
                nap = int.Parse(Console.ReadLine());
            }
            while (nap < 1 || nap > 40);
            int a = 0;
            int h = 0;
            int f = 0;
            for (int i = 0; i < nap; i++)
            {
                a += np[i].KeszA + np[i].EladottA;
                h += np[i].KeszH + np[i].EladottH;
                f += np[i].KeszF + np[i].EladottF;
            }
            Console.WriteLine($"\tA(z) {nap} nap végén {h} harang, {a} angyalka és {f} fenyőfa maradt");

            Console.Write("7.feladat: Legtöbbet eladott dísz");
            Dictionary<string, int> eladott = new Dictionary<string, int>();
            eladott.Add("harang", 0);
            eladott.Add("angyalka", 0);
            eladott.Add("fenyőfa", 0);
            foreach (NapiMunka disz in np)
            {
                eladott["harang"] -= disz.EladottH;
                eladott["angyalka"] -= disz.EladottA;
                eladott["fenyőfa"] -= disz.EladottF;
            }
            int max = eladott.Values.Max();
            Console.WriteLine($"{max}db");
            foreach (var item in eladott)
            {
                if(item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }

            Console.WriteLine("8.feladat: ");
            StreamWriter sw = new StreamWriter("bevetel.txt");
            int min10k = 0;
            foreach (NapiMunka disz in np)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap} : {disz.NapiBevetel()}");
                    min10k++;
                }
            }
            sw.WriteLine($"{min10k} napon volt minimum 10000Ft a bevétel");
            sw.Close();


            Console.ReadKey();
        }
    }
}
