using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_10_mátrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] randomoltszamok_Matrix = new int[3,3];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j <randomoltszamok_Matrix.GetLength(1); j++)
                {
                    randomoltszamok_Matrix[i, j] = r.Next(0, 100);
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
            Console.ReadKey();
        }
    }
}
