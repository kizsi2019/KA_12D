using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömbök
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] randomoltszamok_Vektor = new int[10];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
            {
                randomoltszamok_Vektor[i] = r.Next(0, 100);
            }
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Rendezve");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(randomoltszamok_Vektor);
            Console.WriteLine("Forditva");
            foreach (int forditott in randomoltszamok_Vektor)
            {
                Console.WriteLine(forditott);
            }
            int[,] randomoltszamok_Matrix = new int[3, 3];

            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    randomoltszamok_Matrix[i, j] = r.Next(0, 100);
                }
            }
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }

            int[,] randomoltszamok_Matrix = new int[3, 3];
            
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a mátrix egy elemeit");
                    randomoltszamok_Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }
            int osszeg = 0;
            foreach(int item in randomoltszamok_Matrix)
            {
                osszeg = osszeg + item;
            }
            Console.WriteLine("A mátrix összege :" + osszeg);

            int min = 100;
            int max = 0;

            foreach(int item in randomoltszamok_Matrix)
            {
                if(item > max)
                {
                    max = item;
                }
            }
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            Console.WriteLine("Minimum: " + min + " Maximum: " + max);

            Console.WriteLine("Adja meg a karakterlancot: ");
            string str = Console.ReadLine();
            uint szamlalo = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    szamlalo++;
                }
            }
            Console.WriteLine("szokozok szama: " + szamlalo);

            string str = "Szoftverfejlesztes";
            string str2 = str.Substring(8, 3);

            Console.WriteLine(str);
            Console.WriteLine(str2);

            string str = "Reges reg varva vart engem";
            int i = str.IndexOf("var");
            Console.WriteLine(str);
            Console.WriteLine(i);

            string str = "Reges reg varva vart";
            string str2 = str.Replace("var", "art");

            string str = "kisbetu";
            string str2 = str.ToUpper();

            string str = "C# programozas konyv";
            string[] strT = str.Split(' ');
            foreach (string item in strT)
            {
                Console.WriteLine(item);
            }*/

            string str = " kis betu ";
            string str2 = str.Trim();




            Console.ReadKey();
        }
    }
}
