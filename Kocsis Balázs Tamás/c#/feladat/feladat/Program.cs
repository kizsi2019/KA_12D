using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi a neved?");
            string nev = Console.ReadLine();

            List<int> jegyek = new List<int>();


            Console.WriteLine("Add meg az egyik tantargyad jegyeit!");
            int jegy = Console.Read();
            jegyek.Add(jegy);
            

        }
    }
}
