using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace négyzet_terület
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("add meg a négyzet területét");
            int szam = 0;
            szam = Convert.ToInt32(Console.ReadLine());
            int terulet = szam * szam;
            Console.WriteLine(terulet);
            int kerulet = szam * 4;
            Console.WriteLine(kerulet);
            Console.ReadKey();
        }
    }
}
