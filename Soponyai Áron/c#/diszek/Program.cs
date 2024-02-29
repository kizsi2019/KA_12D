using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using napimunka;
using System.ComponentModel;

namespace diszek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Napimunka> Adatok = new List<Napimunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                Adatok.Add(new Napimunka(sor));
            }
            //4. feladat

            Console.WriteLine($"4. feladat: Össz kész díszek száma: {Napimunka.KeszultDb}");

            //5. feladat 

            bool nemKeszultdisz = false;
            foreach (Napimunka disz in Adatok)
            {
                if (disz.KészHarangok == 0 && disz.KészAngyalok == 0 && disz.KészFák == 0)
                {
                    nemKeszultdisz = true;
                    break;
                }
            }

            if (nemKeszultdisz == true)
            {
                Console.WriteLine("5. feladat: Nem készített az egyik nap díszt");
            }
            else { Console.WriteLine("5. feladat: Minden nap készített díszt"); }

            //6 feladat
            int nap;
            do
            {
                Console.WriteLine("adja meg a keresett napot [1-40]");
                nap = int.Parse(Console.ReadLine());
            } while (nap < 1 || nap > 40);
            int harang = 0;
            int angyal = 0;
            int fa = 0;
            for (int i = 0; i < nap; i++)
            {
                harang += Adatok[i].KészHarangok + Adatok[i].EladottHarangok;
                angyal += Adatok[i].KészAngyalok + Adatok[i].EladottAngyalok;
                fa += Adatok[i].KészFák + Adatok[i].EladottFák;
            }

            Console.WriteLine($"6feladat: A(z) {nap}. nap végén {harang} harang, {angyal} angyal és {fa} fa maradt.");


            //7 feladat

            Console.WriteLine("7. feladat: a legtöbbet eladott dísz: ");
            Dictionary<string, int> eladott = new Dictionary<string, int>();
            eladott.Add("Harang", 0);
            eladott.Add("Angyalka", 0);
            eladott.Add("Fenyofa", 0);

            foreach (Napimunka dísz in Adatok)
            {
                eladott["Harang"] -= dísz.EladottHarangok;
                eladott["Angyalka"] -= dísz.EladottAngyalok;
                eladott["Fenyofa"] -= dísz.EladottFák;
            }
            int max = eladott.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var i in eladott) 
            {
                if (i.Value == max)
                {
                    Console.WriteLine($"\t{i.Key}");
                }
            }

            Console.WriteLine();

            //8 feladat

            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb10000 = 0;
            foreach (Napimunka dísz in Adatok)
            {
                if (dísz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{dísz.Nap}: {dísz.NapiBevetel()}");
                    Console.WriteLine($"{dísz.Nap}: {dísz.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon legalább 10000 Ft a bevétel");
            Console.WriteLine($"{legalabb10000} napon legalább 10000 Ft a bevétel");
            sw.Close();
            Console.ReadKey();
        }
    }
}
