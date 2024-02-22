using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
{
    internal class Program
    {
        delegate void Beleptetes(string str);
        static void Udvozles(string nev)
        {
            Console.WriteLine($"\nÜdvözöllek {nev}");
        }
        static void Uzenet(string nev)
        {
            Console.WriteLine($"Kedves {nev}, köszönjük a belépésedet a rendszerbe!");
        }
        static void Main(string[] args)
        {
            Beleptetes b = new Beleptetes(Udvozles) + new Beleptetes(Uzenet);
            Console.Write("Add meg a nevedet: ");
            string nev = Console.ReadLine();
            b(nev);
            Console.ReadKey();
        }
    }
}
