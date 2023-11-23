using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_14._3_tömbbb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legnagyobb_index = 0;
            int legnkisebb_index = 0;
            for(int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] < Tömb[legnkisebb_index]) legnkisebb_index = i;
            }
            Console.WriteLine("legnagyobb elem index {0}, érték {1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine("legkisebb elem index {0}, érték {1}", legnkisebb_index, Tömb[legnkisebb_index]);
            Console.ReadKey();
        }
    }
}
