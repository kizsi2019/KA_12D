using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PeldaStatkonv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek add meg a négyzet oldalát: ");
            int oldal = Convert.ToInt32(Console.ReadLine());
            int kerulet = oldal * 4;
            Console.WriteLine("A négyzet kerülete: " + kerulet + "\nA területe: " + oldal * oldal);
            Console.ReadKey();


        }
    }
}





