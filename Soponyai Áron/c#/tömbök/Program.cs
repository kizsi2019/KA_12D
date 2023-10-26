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

            /* 
             int[] randovektor = new int[10];
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
             }
             

            int[,] randomatrix = new int[3,3];

            Random rand = new Random();
            for (int i = 0; i < randomatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomatrix.GetLength(1); j++)
                {
                    randomatrix[i, j] = rand.Next(0, 100);
                }
                
            }
            

            int sor = 0;
            int oszlop = 0;
            sor = Convert.ToInt16(Console.ReadLine());
            oszlop = Convert.ToInt16(Console.ReadLine());

            int[,] randomatrix = new int[sor, oszlop];

            Random rand = new Random();
            for (int i = 0; i < randomatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomatrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a mátrix elemeit");
                    randomatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("Bejárás for ciklusokkal");

            for (int i = 0; i < randomatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomatrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", randomatrix[i, j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Bejárás foreach ciklusokkal");
            foreach (int item in randomatrix)
            {
                Console.Write("{0} ", item);
            }

            int osszeg = 0;
            for (int i = 0;i < randomatrix.GetLength(0);i++) 
            {
                for (int j = 0; j < randomatrix.GetLength(1); j++)
                {
                    osszeg += randomatrix[i, j];
                }
            }
            
            int min = randomatrix[0, 0];
            foreach (int item in randomatrix)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            int max = randomatrix[0, 0];
            foreach (int item in randomatrix)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine("Az összeg: " + osszeg);
            Console.WriteLine("Az min: " + min);
            Console.WriteLine("Az max: " + max);
            

            Console.WriteLine("Adja meg a karakter láncot: ");
            string str = Console.ReadLine();
            uint szamlalo = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    szamlalo++;
                }
            }
            Console.WriteLine("Szóközök száma: " + szamlalo);
            

            string str = "Szoftverfejlesztés";
            string str2 = str.Substring(8,3);
            Console.WriteLine(str2);
            

            string str = "réges régvárva várt engem";
            int index = str.IndexOf("vár");
            Console.WriteLine(index);
            

            string str = "réges régvárva várt engem";
            string str2 = str.Replace("vár", "árt");
            Console.WriteLine(str2);

            string str = "réges régvárva várt engem";
            string str2 = str.ToUpper();
            Console.WriteLine(str2);
            
            string str = "réges régvárva várt engem";
            string[] str2 = str.Split(' ');
            foreach (string item in str2) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(str2);
            

            string str = "réges régvárva várt engem";
            string str2 = str.Insert(0, "asd");
            Console.WriteLine(str2);

            string str = "réges régvárva várt engem";
            string str2 = str.PadLeft(6, "asd");
            Console.WriteLine(str2);
            */

            Console.ReadKey();
        }
    }
}
