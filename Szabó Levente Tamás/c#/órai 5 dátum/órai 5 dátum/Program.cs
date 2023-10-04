using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_5_dátum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            DateTime c = DateTime.Now;
            Console.WriteLine(c.DayOfYear);
            Console.ReadKey();
        }
    }
}
