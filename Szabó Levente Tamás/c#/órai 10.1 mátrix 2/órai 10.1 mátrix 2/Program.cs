using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace órai_10._1_mátrix_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] randomoltszamok_Matrix = new int[3, 3];
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a mátrix egyik elemét! ");
                    randomoltszamok_Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Rendezve");
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(randomoltszamok_Matrix);
            Console.WriteLine("Fordítva");
            foreach (int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }
            int összeg = randomoltszamok_Matrix[0, 0];
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item > összeg)
                {
                    összeg = item;
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
            int min = randomoltszamok_Matrix[0, 0];
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item > min)
                {
                    min = item;
                }
            }
            Console.WriteLine("A mátrix összege: " + összeg);
            Console.WriteLine("A mátrix összege: " + max);
            Console.WriteLine("A mátrix összege: " + min);
            Console.ReadKey();
        }
    }
}
