using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyaki3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int ma = 21;
            int tegnap = 18;
            var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);

            Console.WriteLine(szoveg);

            Console.WriteLine("így is lehet: {0}, {1}", ma, tegnap);

            Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 124123);
            Console.WriteLine("Exponenciális: {0:E}", 123413);
            Console.WriteLine("Hexa: {0:X}", 255);
            

            double d = 1500.42;

            Console.WriteLine("{0:00.0000}", d);
            Console.WriteLine("{0:(#).##}", d);
            Console.WriteLine("{0:0.0}", d);
            Console.WriteLine("{0:0,0}", d);
            Console.WriteLine("{0:0%}", d);
            Console.WriteLine("[{0,-5}]", "Foo");
            Console.WriteLine("[{0,5}]", "Foo");
            //pozitív
            Console.WriteLine("{0:pozitív;negatív;nulla}", 4);
            //negatív
            Console.WriteLine("{0:pozitív;negatív;nulla}", -4);
            //nulla
            Console.WriteLine("{0:pozitív;negatív;nulla}", 0);

            string nev = "World";
            string hello = $"Hello {nev}!";
            Console.WriteLine(hello);

            
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);
            DateTime c = DateTime.Now;
            Console.WriteLine(c.DayOfYear);

            int szuletesi_ev = 2004;
            int kor = DateTime.Now.Year - szuletesi_ev;
            Console.WriteLine(kor);

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
            Console.WriteLine("{0:yyyy-mm-dd, dddd tt hh:mm:ss}", ido);*/

            double a = Math.Abs(-123);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double d = Math.Round(1.23);
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
