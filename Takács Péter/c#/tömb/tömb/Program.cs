
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] randovektor = new int[10];
            int[] rendezett = new int[10];
            Random rand = new Random();
            for (int i = 0; i < randovektor.Length; i++)
            {
                randovektor[i] = rand.Next(0, 100);
            }
            foreach (int item in randovektor)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Rendezve");

            Array.Sort(randovektor);

            foreach (int item in randovektor)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Fordítva");

            Array.Reverse(randovektor);

            foreach (int item in randovektor)
            {
                Console.WriteLine(item);
            }*/
            /*int[,] randomoltszamok_Matrix = new int[3, 3];
            for(int i = 0;i < randomoltszamok_Matrix.GetLength(0);i++) 
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a mmátrix elemét! ");
                    randomoltszamok_Matrix[i, j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            foreach(int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Adja meg a karakter láncot: ");
            string str = Console.ReadLine();
            uint szamlalo = 0;
            for (int i = 0; i < str.Length; i++) 
            { 
                if (str[i] == ' ' )szamlalo++;
            }
            Console.WriteLine("Szóközök száma: " + szamlalo);
            string str = "Szoftverfejlesztés";
            string str2 = str.Substring(8, 3);
            string str3 = "Réges rég várva várt engem";
            string str4 = str.Replace("várva", "árt");

            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);*/
            string str = "C# programozás könyv";
            string strT = str.Split(' ');
            foreach (string item in strT) {Console.WriteLine }

            Console.ReadKey();
        }
    }
}
