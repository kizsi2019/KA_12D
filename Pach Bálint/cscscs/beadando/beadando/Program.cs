using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a neved: ");
            string név = Console.ReadLine();
            List<int> jegyek = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Convert.ToInt32(jegyek);
            double átlag = Convert.ToDouble(jegyek);
            Console.WriteLine("A {0} nevű tanulónak {1} az átlaga", név, átlag);
            Console.ReadKey(); 
        }
    }
}
