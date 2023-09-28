using System;

namespace órai_7_matekos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Math.Abs(-123);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double d = Math.Round(1.533333, 2);
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}