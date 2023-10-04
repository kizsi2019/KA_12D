using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 132354);
            Console.WriteLine("Exponenciális: {0:E}", 132354);
            Console.WriteLine("Hexa: {0:X}", 255);
            Console.ReadKey();
        }
    }
}
