using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    internal class Program
    {
        delegate void VoidDelegate();
        static void Metódus()
        {
            Console.WriteLine("A metódus lefutott");
        }
        static void Main(string[] args)
        {
            VoidDelegate vd = new VoidDelegate(Metódus);
            vd();
            Console.ReadKey();
        }
    }
}
