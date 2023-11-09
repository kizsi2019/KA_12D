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
            
            int osszeg = 0;
            string nev;
            int atlag = 0;
            int min = 0;
            int max = 0;
            List<int> jegyek = new List<int>();

            Console.WriteLine("Kérem a nevét:");
            nev = Console.ReadLine();
            do
            {
                Console.WriteLine("Kérem a jegyeket:");
                int szam = Console.ReadLine();
                jegyek.Add(szam);
            } while (szam != " "));

            for (int i = 0; i < jegyek.Count; i++)
            {
                if (jegyek[i] < jegyek[min]) min = i;
                if (jegyek[i] > jegyek[max]) max = i;
            }

            Console.WriteLine($"{nev.ToUpper} átlaga: {atlag}");
            Console.WriteLine($"{nev.ToUpper} legjobb jegye: {max}");
            Console.WriteLine($"{nev.ToUpper} legrosszabb jegye: {min}");
            Console.ReadKey();
        }
    }
}
