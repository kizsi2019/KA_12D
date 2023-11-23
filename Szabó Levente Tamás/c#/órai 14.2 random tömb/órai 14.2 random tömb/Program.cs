using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_14._2_random_tömb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            foreach (int i in randT)
            {
                Console.WriteLine(i);
            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");
        }
    }
}
