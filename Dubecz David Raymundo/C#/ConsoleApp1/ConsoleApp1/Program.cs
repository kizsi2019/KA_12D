using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            // Felhasználó nevének bekérése
            Console.Write("Kérem, adja meg a nevét: ");
            string nev = Console.ReadLine();

            // Jegyek tárolására használt lista
            List<int> jegyek = new List<int>();

            // Jegyek bekérése és ellenőrzése
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Kérem, adja meg a(z) {i + 1}. jegyet: ");
                if (int.TryParse(Console.ReadLine(), out int jegy) && jegy >= 1 && jegy <= 5)
                {
                    jegyek.Add(jegy);
                }
                else
                {
                    Console.WriteLine("Érvénytelen jegy! Kérem, adjon meg egy 1 és 5 közötti egész számot.");
                    i--; // Csökkentjük a ciklusváltozót, hogy ismételje meg a bekérést
                }
            }

            // Jegyek átlagának számolása
            double atlag = jegyek.Count > 0 ? jegyek.Average() : 0;

            // Legjobb és legrosszabb jegy kiválasztása
            int legjobbJegy = jegyek.Count > 0 ? jegyek.Max() : 0;
            int legrosszabbJegy = jegyek.Count > 0 ? jegyek.Min() : 0;

            // Eredmények kiírása
            Console.WriteLine($"{nev.ToUpper()} átlaga: {atlag:F2}");
            Console.WriteLine($"{nev.ToUpper()} legjobb jegye: {legjobbJegy}");
            Console.WriteLine($"{nev.ToUpper()} legrosszabb jegye: {legrosszabbJegy}");

            Console.ReadLine(); // Várakozás, hogy ne záródjon be az ablak azonnal
        }
    }
}
