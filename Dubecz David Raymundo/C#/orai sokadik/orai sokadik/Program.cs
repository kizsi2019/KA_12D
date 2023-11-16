using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_sokadik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jegy;
            int osszeg = 0;
            int min = 0;
            int max = 0;
            List<int> jegyek = new List<int>();

            Console.WriteLine("Adj nevet!");
            string nev = Console.ReadLine();

            while (true)
            {
                Console.Write("Adj jegyet vagy ird hogy vége hogy veget erjen ");
                string input = Console.ReadLine();

                if (input.ToLower() == "vége")
                {
                    break;
                }

                if (int.TryParse(input, out jegy) && (jegy >= 1 && jegy <= 5))
                {
                    jegyek.Add(jegy);
                }
                else
                {
                    Console.WriteLine("Hiba. Adj meg jegyet vagy írd hogy vége");
                }
            }

            foreach (int item in jegyek)
            {
                osszeg += item;
            }
            double atlag = osszeg / jegyek.Count;

            for (int i = 0; i < jegyek.Count; i++)
            {
                if (jegyek[i] < jegyek[min]) min = i;
                if (jegyek[i] > jegyek[max]) max = i;
            }

            // Eredmények kiírása
            Console.WriteLine($"{nev.ToUpper()} Átlag: {atlag:F2}");
            Console.WriteLine($"{nev.ToUpper()} Legjobb jegy: {max}");
            Console.WriteLine($"{nev.ToUpper()} Legrosszabb jegy: {min}");
            Console.ReadKey();
        }
    }
}