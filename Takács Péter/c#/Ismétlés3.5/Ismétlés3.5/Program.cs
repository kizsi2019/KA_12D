using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismétlés3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);*/
            /*DateTime c = DateTime.Now;
            Console.WriteLine(c.DayOfYear);
            Console.ReadKey();
            int szülév = 2004;
            int eletkor = DateTime.Now.Year - szülév;
            int napos = DateTime.Now.Day - szülév;
            Console.WriteLine(eletkor);
            Console.WriteLine(napos);
            Console.ReadKey();
            var ido = DateTime.Now;


            Console.WriteLine("{0:d}", ido);
            Console.WriteLine("{0:D}", ido);
            Console.WriteLine("{0:t}", ido);
            Console.WriteLine("{0:T}", ido);
            Console.WriteLine("{0:f}", ido);
            Console.WriteLine("{0:F}", ido);
            Console.WriteLine("{0:g}", ido);
            Console.WriteLine("{0:G}", ido);
            Console.WriteLine("{0:M}", ido);
            Console.WriteLine("{0:r}", ido);
            Console.WriteLine("{0:Y}", ido);
            Console.WriteLine("{0:yyyy-mm-dd, dddd tt hh:mm:ss}", ido);
            Console.ReadKey();*/

            int a = Math.Abs(-1223);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double d = Math.Round(1.53);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
