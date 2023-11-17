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
            Console.Write("Add meg a neved: ");
            string név = Console.ReadLine();
            List<int> jegyek = new List<int>() {2, 5};
            double átlag = Queryable.Average(jegyek.AsQueryable());
            Console.WriteLine("{0} tanulónak az átlaga {1}", név, átlag);
            Console.ReadKey();
        }
    }
}