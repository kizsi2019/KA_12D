using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ember e = new Ember("József", 18, 1138);
            Console.WriteLine(e.Nev);
            Console.WriteLine(e.Eletkor);
            Console.WriteLine(e.Iranyitoszam);
            Console.ReadKey();
        }
    }
}
