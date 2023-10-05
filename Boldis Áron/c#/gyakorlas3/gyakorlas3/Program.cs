using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace gyakorlas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int ma = 21;
            int tegnap = 18;
            var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);

            Console.WriteLine(szoveg);

            Console.WriteLine("Így is lehet: {0}, {1}", ma, tegnap);*/

            /*Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 132354);
            Console.WriteLine("Exponenciális: {0:E}", 132354);
            Console.WriteLine("Hexa: {0:X}", 255);
            Console.ReadKey();*/

            /*double d = 1500.42;

            //1500,4200
            Console.WriteLine("{0:00.0000}", d);
            //(1500),42
            Console.WriteLine("{0:(#).##}", d);
            //1500,4
            Console.WriteLine("{0:0.0}", d);
            //1 500
            Console.WriteLine("{0:0,0}", d);
            //150042%
            Console.WriteLine("{0:0%}", d);
            //[Foo  ]
            Console.WriteLine("[{0,-5}]", "Foo");
            //[  Foo]
            Console.WriteLine("[{0,5}]", "Foo");

            //pozitív
            Console.WriteLine("{0:pozitív;negatív;nulla}", 4);
            //negatív
            Console.WriteLine("{0:pozitív;negatív;nulla}", -4);
            //nulla
            Console.WriteLine("{0:pozitív;negatív;nulla}", 0);
            */

            /* var elso = "c:\\teszt\\foo";
             //picivel egyszerűbb:
             var masodik = @"c:\teszt\foo";*/

            /*string nev = "World";
            string hello = $"Hello {nev}!";
            Console.WriteLine(hello);*/

            /*Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);
            DateTime c = DateTime.Now;
            Console.WriteLine(c.DayOfYear);
            Console.WriteLine(DateTime.Now);*/

            /*int dob = 2013;
            int eletkor = DateTime.Now.Year - dob;
            Console.WriteLine(eletkor);*/

            /*var ido = DateTime.Now;

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

            /*string teszt = "🐰";
            Console.WriteLine("A szoveg hossza: {0}", teszt.Length);

            var info = new StringInfo(teszt);
            Console.WriteLine("A szoveg valodi hossza: {0}", info.LengthInTextElements);*/

            /*int a = Math.Abs(-123);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(b);
            double d = Math.Round(1.53333, 2);
            Console.WriteLine(b);*/

            /*Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);*/

            /*try
            {
                Console.WriteLine("Add meg a kör sugarát: ");
                int r = Convert.ToInt32(Console.ReadLine());
                double kerulet = Math.Round(2 * r * Math.PI, 2);
                double terulet = Math.Round(Math.Pow(r, 2) * Math.PI, 2);
                Console.WriteLine("Kerület: " + kerulet);
                Console.WriteLine("Terület: " + terulet);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }*/


            /*checked
            {
                int a2 = 100000;
                int b2 = 100000;
                long c2 = a2 * b2;
            }*/
            /*
            try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
            }
            */

            Console.WriteLine("Add meg a kör sugarát: ");
            try
            {
                string r = Console.ReadLine();
                int parsed;

                if (int.TryParse(r, out parsed))
                {
                    double kerulet = Math.Round(2 * parsed * Math.PI, 2);
                    double terulet = Math.Round(Math.Pow(parsed, 2) * Math.PI, 2);
                    Console.WriteLine("A kör területe {0} \n A kerülete {1}", kerulet, terulet);
                }
                else
                {
                    throw new Exception("Kérlej számot adj meg");
                }
                
            }

            catch (Exception ex)
            {
                Console.WriteLine("HIBA történt");
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
