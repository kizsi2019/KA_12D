using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_13._6_beadandó
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a neved: ");
            string név = Console.ReadLine();
            List<int> jegyek = new List<int>() {1,2,3,4,5,6};
            foreach (int i in jegyek)
            {
                Console.WriteLine(i);
            }
            double átlag = Convert.ToDouble(jegyek);
            Console.WriteLine("{0} tanulónak az átlaga {1}", név, átlag);
            Console.ReadKey();
        }
    }
}
