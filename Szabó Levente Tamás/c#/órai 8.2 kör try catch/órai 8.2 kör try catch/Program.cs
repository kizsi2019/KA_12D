using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_8_2_kör_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a kör sugarát");
            try
            {
                var bevitel = Console.ReadLine();
                int sugar;
                if(int.TryParse(bevitel, out sugar))
                {
                    double kerulet = 2 * sugar * Math.PI;
                    double terulet = sugar * sugar * Math.PI;
                    Console.WriteLine($"A kör kerülete {kerulet}");
                    Console.WriteLine($"A kör területe {terulet}");
                }
                else
                {
                    throw new Exception("Nem nyert");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Minden jó");
            }
            Console.ReadLine();
        }
    }
}
