using System;

namespace órai_7_matekos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = Math.Abs(-123);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double d = Math.Round(1.533333, 2);
            Console.WriteLine(d);
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);*/

            //kör(sugara, kerülete, területe)

            Console.WriteLine("Add meg a sugarát.");
            double r = Convert.ToDouble(Console.ReadLine());

            double kerület = 2 * r * Math.PI;
            double terület = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine($"A kerülete {1} lett", kerület);
            Console.WriteLine($"A kerülete {1} lett", terület);

            Console.ReadKey();
        }
    }
}