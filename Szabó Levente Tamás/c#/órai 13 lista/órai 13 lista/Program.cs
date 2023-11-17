using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_13_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(8);
            list.Add(12);
            list.Add(43);
            list.Add(2);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Kapacitása: " + list.Capacity);
            Console.WriteLine("Mérete: " + list.Count);
            Console.ReadKey();
        }
    }
}
