using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombok
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
            Array.Sort(randomoltszamok_Vektor);
            Console.WriteLine("Rendezve");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(randomoltszamok_Vektor);
            Console.WriteLine("Rendezve");
            foreach (int item in randomoltszamok_Vektor)
            {
                Console.WriteLine(item);
            }*/

            /*int[,] randomoltszamok_Matrix = new int[3, 3];
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
            }*/

            int[,] randomoltszamok_Matrix = new int[3, 3];
            int osszeg = 0;
            
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a mátrix egy elemét!");
                    randomoltszamok_Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            foreach (int item in randomoltszamok_Matrix)
                {
                    osszeg += item;
                }
            int min = randomoltszamok_Matrix[0, 0];
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            int max = randomoltszamok_Matrix[0, 0];
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine("A mátrix összege: " + osszeg);
            Console.WriteLine("A mátrix legnagyobb száma: " + max);
            Console.WriteLine("A mátrix legkisebb száma: " + min);
            Console.ReadKey();
        }
    }
}
