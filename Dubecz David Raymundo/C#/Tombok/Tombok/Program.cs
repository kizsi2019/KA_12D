using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] randomoltszamok_Vektor = new int[10];
            Random r = new Random();

            
            for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
            {
                //for ciklussal írni és olvasni is tudunk
                randomoltszamok_Vektor[i] = r.Next(0, 100);
            }
            foreach (int item in randomoltszamok_Vektor)
            {
                //csak olvasásra jó
                Console.WriteLine(item);
            }

            Array.Sort(randomoltszamok_Vektor);
            Console.WriteLine("Rendezve:");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(randomoltszamok_Vektor);
            Console.WriteLine("Fordítva:");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }

            int[,] randomoltszamok_Matrix = new int[3,3];
            Random r = new Random();


            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; i < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    randomoltszamok_Matrix[i, j] = r.Next(0, 100);
                }
            }
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            int[,] randomoltszamok_Matrix = new int[3, 3];
            int osszeg = 0;
            int min = randomoltszamok_Matrix[0, 0];
            int max = randomoltszamok_Matrix[0, 0];

            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a mátrix egy elemét:");
                    randomoltszamok_Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }

            foreach (int item in randomoltszamok_Matrix)
            {
                osszeg += item;

                if (item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }
            }

            Console.WriteLine("A mátrix összege: {0}", osszeg);
            Console.WriteLine("Legkisebb: {0}", min);
            Console.WriteLine("Legnagyobb: {0}", max);
            Console.ReadKey();

            // A string egy tömb, bővebben a stringekről
            Console.WriteLine("Adja meg a karakterláncot: ");
            string str = Console.ReadLine(); //mivel tudjuk, hogy a szamlalo sohasem lesz negatív, ezért állítsuk uint-re a típusát és 0 kezdőértékkel
            uint szamlalo = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    szamlalo++;
                }
            }
            Console.WriteLine("Szóközök száma: {0}", szamlalo);
            */

            string str1 = "Szoftverfejlesztés";
            string str2 = str1.Substring(8, 3); //fej
            Console.WriteLine(str2);

            string str3 = "Réges rég várva várt engem";
            int index = str3.IndexOf("vár"); //10
            int index2 = str3.IndexOf("kabát"); //-1
            Console.WriteLine(index);
            Console.WriteLine(index2);

            string str4 = "Réges rég várva várt";
            string str5 = str4.Replace("vár", "árt"); //Réges rég ártva ártt
            Console.WriteLine(str5);

            string str6 = "kisbetű";
            string str7 = str6.ToUpper(); //KISBETŰ
            //string str 7 = str6.ToLower(); //kisbetű

            string str8 = "C# programozás könyv";
            string[] strT = str8.Split(' ');
            foreach (string item in strT)
            {
                Console.WriteLine(item);
            }

            string str9 = " lebegne ";
            string str10 = str9.Trim();
            Console.WriteLine(str10);

            string str11 = "lebegne";
            string str12 = str11.Remove(3, 4);
            Console.WriteLine(str12);

            // string.Contains(string) Tartalmazás vizsgálat, logikai értékkel tér vissza.

            string str13 = "fejlesztő";
            string str14 = str13.Insert(0, "C# "); //C# fejlesztő

            string str15 = "alma";
            string str16 = str15.PadRight(6, '!'); // alma??

            Console.ReadKey();
        }
    }
}
