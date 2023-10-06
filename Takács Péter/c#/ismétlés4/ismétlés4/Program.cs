using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismétlés4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string szoveg = "valami szöveg";
            int szam = Convert.ToInt32(szoveg); Console.WriteLine(szam); Console.ReadKey();

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
            Console.ReadKey();
            try
            {
                string szoveg = "valami szöveg";
                int szam = Convert.ToInt32(szoveg); Console.WriteLine(szam);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Valami hiba történt: {0}", ex.Message);
                throw; //hibát tovább dobjuk.
            }
            Console.ReadKey();*/
            Console.WriteLine("Kettővel szorzó v. 1.0"); Console.WriteLine("Adjon meg egy egész páros számot!");
            try
            {
                var bevitel = Console.ReadLine();
                int sugar;

                if (int.TryParse(bevitel, out sugar)) 
                {
                    double kerulet = 2 * sugar * Math.PI;
                    double terulet = sugar * sugar * Math.PI;
                else
                    {
                        throw new Exception("a szam nem paros! ");
                    }
                }
                Console.WriteLine($"A szorzás eredménye: {szam * 2}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("HIBA történt"); Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez"); 
                Console.ReadKey();
            }
        }
    }
}
