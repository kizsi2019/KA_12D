using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ToTo> totoes = new List<ToTo>();
            foreach (string line in File.ReadLines("toto.txt").Skip(1))
            {
                totoes.Add(new ToTo(line));
            }
            Console.WriteLine();

            //3.Feladat
            Console.WriteLine($"3.feladat: fordulók száma: {totoes.Count}");

            //4.Feladat
            double sum = 0;
            for (int i = 0; i < totoes.Count; i++)
            {
                sum += totoes[i].T13p1;
            }
            Console.WriteLine($"4.feladat: telitalálatos szelvények száma: {sum}");

            //5.Feladat
            List<double> item = new List<double>();
            for (int i = 0; i < totoes.Count; i++)
            {
                double temp = totoes[i].T13p1 * totoes[i].Ny13p1;
                if (temp > 0)
                {
                    item.Add(temp);
                }
            }
            double osszeg = item.Sum();
            double avg = osszeg / totoes.Count;
            Console.WriteLine($"5.feladat: {avg}Ft");

            //6.Feladat
            int max = 0;
            int min = 0;
            foreach ( i totoes)
            {
                Console.WriteLine("8.feladat:");
                Console.WriteLine("\tLegnagyobb:");
                Console.WriteLine("\tÉv:");
                Console.WriteLine("\tHét:");
                Console.WriteLine("\tForduló:");
                Console.WriteLine("\tTelitalálat:");
                Console.WriteLine("\tNyeremény:");
                Console.WriteLine("\tEredmények:");

                Console.WriteLine("\tLegkisebb:");
                Console.WriteLine("\tÉv:");
                Console.WriteLine("\tHét:");
                Console.WriteLine("\tForduló:");
                Console.WriteLine("\tTelitalálat:");
                Console.WriteLine("\tNyeremény:");
                Console.WriteLine("\tEredmények:");
            }

            //7.Feladat


            //8.Feladat


            Console.ReadKey();
        }
    }
}
