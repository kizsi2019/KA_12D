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
            Console.WriteLine("Adja meg a nevét: ");
            long szam1 = 0;
            do
            {
                Console.WriteLine("Adjon meg számokat: ");
            }
            while (!long.TryParse(Console.ReadLine(), out szam1));
            int min = 0;
            int max = 0;
            if (szam1 < min) 
            {
                Console.WriteLine("A legkisebb szám {szam1}");
            }
            if (szam1 > max)
            {
                Console.WriteLine("A legnagyobb szám {szam1}");
            }

            Console.ReadKey();
        }
    }
}
