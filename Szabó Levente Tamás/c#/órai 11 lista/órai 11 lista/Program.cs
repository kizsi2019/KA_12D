using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_11_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a karaktert: ");
            string str = Console.ReadLine();
            uint szamlalo = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') szamlalo++;
            }
            Console.WriteLine("Szóközök száma: " + szamlalo++);
            Console.ReadKey();
        }
    }
}
