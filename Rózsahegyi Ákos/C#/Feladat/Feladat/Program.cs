using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Készíts egy programot, mely a felhasználótól bekéri a nevét (pl. Kovács István),
            majd bekéri valamelyik tantárgyból a jegyeit. A bekérés ellenőrzötten történjen!
            
            - Tárolja az adatokat megfelelő adatszerkezetben! (List)
            - Számolja ki a jegyek átlagát, válassza ki a legjobb és legrosszabb jegyet
            - Írja ki ezeket a következő formában:
            KOVÁCS ISTVÁN átlaga: 2,33 (két tizedes jegyre kerekítve)
            KOVÁCS ISTVÁN legjobb jegye: 5
            KOVÁCS ISTVÁN legrosszabb jegye: 2
            */

            int jegy;
            int osszeg = 0;
            int min = 0;
            int max = 0;
            List<int> jegyek = new List<int>();

            // Név megadása és tárolása
            Console.WriteLine("Kérem a nevét (pl. Kovács István): ");
            string nev = Console.ReadLine();

            // Jegyek bekérése és tárolása listába
            while (true)
            {
                Console.Write($"Adja meg a jegyet (1-5), vagy írja be hogy 'vége' a befejezéshez: ");
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
                    Console.WriteLine("Hibás formátum. Kérjük, adjon meg egy érvényes jegyet (1-5) vagy írja be hogy 'vége'.");
                }
            }

            // Jegyek összege és átlagának kiszámítása
            foreach (int item in jegyek)
            {
                osszeg += item;
            }
            double atlag = osszeg / jegyek.Count;

            // Legjobb és legrosszabb jegy keresése
            for (int i = 0; i < jegyek.Count; i++)
            {
                if (jegyek[i] < jegyek[min]) min = i;
                if (jegyek[i] > jegyek[max]) max = i;
            }

            // Eredmények kiírása
            Console.WriteLine($"{nev.ToUpper()} átlaga: {atlag:F2}");
            Console.WriteLine($"{nev.ToUpper()} legjobb jegye: {max}");
            Console.WriteLine($"{nev.ToUpper()} legrosszabb jegye: {min}");
            Console.ReadKey();
        }
    }
}
