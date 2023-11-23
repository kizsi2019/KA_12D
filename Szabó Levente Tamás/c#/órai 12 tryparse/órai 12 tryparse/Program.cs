using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_12_tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            bool tryparse = int.TryParse(Console.ReadLine(), out szam);
            if (tryparse) Console.WriteLine();
            else Console.WriteLine("Rossz bemenet! ");
            Console.ReadKey();
        }
    }
}