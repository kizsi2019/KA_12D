using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var sor in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(sor));
            }
            // 3. feladat
            Console.WriteLine($"3. feladat: Díjazottak száma: {dijazottak.Count} fő");

            // 4. feladat
            int utolsoEv = dijazottak.First().Ev;
            foreach (var item in dijazottak)
            {
                if (item.Ev > utolsoEv)
                {
                    utolsoEv = item.Ev;
                }
            }
            Console.WriteLine($"4. feladat: Utolsó év: {utolsoEv}");

            // 5. feladat
            Console.WriteLine("5. feladat: Kérem adja meg egy ország kódját: ");
            string orszagkod = Console.ReadLine().ToUpper();
            List<Dijazott> orszagDijazottjai = new List<Dijazott>();
            foreach (var item in dijazottak)
            {
                if (item.Orszagkod == orszagkod)
                {
                    orszagDijazottjai.Add(item);
                }
                else
                {
                    Console.WriteLine("A megadott országból nem volt díjazott!");
                }
            }
            Console.ReadKey();
        }
    }
}
