using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ism3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int ma = 21;
            int tegnap = 18;
            var szoveg = string.Format("Ma {0} fok volt, tegnap pedig {1}", ma, tegnap);*/

            /*Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P1}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 132354);
            Console.WriteLine("Exponenciélis: {0:E}", 12);
            Console.WriteLine("Hexa: {0:X}", 255);*/

            double d = 1500.42;

            /*//1500,4200
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
            Console.WriteLine("{0:pozitív;negatív;nulla}", 0);*/

            /*int valtozo = 13;
            string interpolalt = $"{nameof(valtozo)} értéke: {valtozo}";*/

            /*string nev = "World";
            string hello = $"Hello {nev}!";
            Console.WriteLine(hello);*/

            /*Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);
            DateTime c = DateTime.Now;
            Console.WriteLine(c.DayOfYear);*/

            /*int szulo_ev = 2013;
            int eletkor = DateTime.Now.Year - szulo_ev;
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
            Console.WriteLine("{0:yyyy-mm-dd, dddd tt hh:mm:ss}", ido);*/

            /*int a = Math.Abs(-123);
            Console.WriteLine(a);
            double b = Math.Ceiling(1.23);
            Console.WriteLine(b);
            double c = Math.Floor(1.23);
            Console.WriteLine(c);
            double r = Math.Round(1.53333, 2);
            Console.WriteLine(r);*/
            /*Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);*/

            /*Console.WriteLine("Adjon meg egy számot: ");
            double sugar = byte.Parse(Console.ReadLine());
            double kerulet = Math.PI * 2 * sugar;
            double terulet = Math.Pow(sugar, 2) * Math.PI;
            Console.WriteLine("A kör kerülete: {0}", kerulet, Math.Round(kerulet, 2));
            Console.WriteLine("A kör kerülete: {0}", terulet, Math.Round(terulet, 2));*/

            /*checked
            {
                int a2 = 100000;
                int b2 = 100000;
                long c2 = a2 * b2;
            }*/

            /*try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg);
                Console.WriteLine(szam);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
            }*/

            /*Console.WriteLine("Kettővel szorzó v. 1.0");
            Console.WriteLine("Adjon meg egy egész páros számot!");
            try
            {
                var bevitel = Console.ReadLine();
                int szam = Convert.ToInt32(bevitel);

                if ((szam % 2) != 0)
                {
                    throw new Exception("A szám nem páros");
                }
                Console.WriteLine($"A szorzás eredménye: {szam * 2}");

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
            }*/

            Console.WriteLine("Add meg a sugarat");
            try
            {
                var bevitel = Console.ReadLine();
                int sugar;
                if (int.TryParse(bevitel, out sugar))
                {
                    double kerulet = 2 * sugar * Math.PI;
                    double terulet = Math.Pow(sugar, 2) * Math.PI;
                    Console.WriteLine("A kör kerülete: {0}", kerulet);
                    Console.WriteLine("A kör területe: {0}", terulet);
                }
                else
                {
                    throw new Exception("Legközelebb számot adj meg légyszives!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA történt.");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
