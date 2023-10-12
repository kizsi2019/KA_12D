using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a kör sugarát: ");

            double rádiusz = Convert.ToDouble(Console.ReadLine());

            double Terület = Math.PI * Math.Pow(rádiusz, 2);
            Console.WriteLine($"A kör területe: {Terület}");

            double kerület = 2 * Math.PI * rádiusz;
            Console.WriteLine($"A kör kerülete: {kerület}");

            Console.ReadKey();

        }
    }
}
