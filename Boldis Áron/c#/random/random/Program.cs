using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
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
            Array.Sort(randomoltszamok_Vektor);
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Fordítva");
            Array.Reverse(randomoltszamok_Vektor);
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }*/

            /*int[,] randomoltszamok_matrix = new int [3,3];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_matrix.GetLength(1); j++)
                {
                    randomoltszamok_matrix[i, j] = r.Next(0, 100);
                }
            }
            foreach (int item in randomoltszamok_matrix)
            {
                Console.WriteLine(item);
            }*/

            /*int[,] randomoltszamok_matrix = new int[3, 3];
            for (int i = 0; i < randomoltszamok_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a mátrix egy elemét!");
                    randomoltszamok_matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            foreach (int item in randomoltszamok_matrix)
            {
                Console.WriteLine(item);
            }

            int sum = 0;
            foreach(int item in randomoltszamok_matrix)
            {
                sum = sum + item;
            }
            Console.WriteLine("Az összeg egynlő: " + sum);

            int max = randomoltszamok_matrix[0, 0];
            int min = randomoltszamok_matrix[0, 0];

            foreach (int i in randomoltszamok_matrix)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine("A legkisebb szám: {0}, a legnagyobb szám: {1}", min, max);*/

            /*Console.WriteLine("Adja meg a karakterláncot: ");
            string str = Console.ReadLine();
            uint szamlalo = 0; 
            for (int i = 0; i < str.Length; i++) 
            {
                if (str[i] == ' ') szamlalo++;
            }
            Console.WriteLine("A szóközök száma: " + szamlalo);*/

            /*string str = "Szoftverfejlesztés";
            string str2 = str.Substring(8, 3);

            string str3 = "Réges rég várva várt engem";
            int index = str3.IndexOf("vár");

            string str = "C# programozás könyv";
            string[] strT = str.Split(' ');
            foreach (string item in strT)
            {
                Console.WriteLine(item);
            }*/




            Console.ReadKey();
        }
    }
}
