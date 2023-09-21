using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismétlés1
{
    namespace PeldaOperatorok
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.Beep(1000, 100000);
                //17 lesz az eredmény
                var kifejezes = 3 * 6 - 2 + 1 % 2;
                Console.WriteLine(kifejezes);

                //így már helyes és az eredmény 1
                var kifejezes2 = (3 * 6 - 2 + 1) % 2;
                Console.WriteLine(kifejezes2);

                Console.Write("A long tipus merete byte-ban: ");
                //8
                int bytes = sizeof(long);
                Console.WriteLine(bytes);

                //binárisan
                // 0000_0001 << 6 => 0100_0000
                int kettohat = 1 << 6;
                Console.WriteLine(kettohat);

                //binárisan
                //1111_0000 >> 2 => 0011_1100
                int balra = 240 >> 2;
                Console.WriteLine(balra);

                //true
                bool logika = 33 > 22;
                //false
                bool logika2 = (33 / 2) == 0;
                Console.WriteLine(logika);
                Console.WriteLine(logika2);

                string szoveg = "ez egy";
                szoveg += " szép mondat.";

                Console.WriteLine(szoveg);

                int x = 3;
                //4 lesz, mert inkrementálás után ír ki
                Console.WriteLine(++x);
                x = 3;
                //3 lesz, mert kiír és csak utána inkrementálja a változót
                Console.WriteLine(x++);
                //4 lesz, mert itt már a növelt értéket látjuk
                Console.WriteLine(x);


                Console.ReadKey();
            }
        }
    }
}
