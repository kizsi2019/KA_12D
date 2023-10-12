using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hóska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szletes = 2013;
            int kor = DateTime.Now.Year - szletes;
            Console.WriteLine(kor);

            Console.ReadKey();
        }
    }
}
