using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a neved! ");
            string nev = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Kérem, adja meg a(z)" ,i + 1 , "jegyet: ");
                if (int.TryParse(Console.ReadLine(), out int jegy) && jegy >= 1 && jegy <= 5)
                {
                    jegyek.Add(jegy);
                }
                else
                {
                    Console.WriteLine("Érvénytelen jegy! Kérem, adjon meg egy 1 és 5 közötti egész számot.");
                    i--;




                }
    }
}
