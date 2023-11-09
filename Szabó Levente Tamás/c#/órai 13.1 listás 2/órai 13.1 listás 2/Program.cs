using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_13._1_listás_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(12);
            list.Add(43);
            list.Add(2);
            list.Insert(1, 31);
            Console.ReadKey();
        }
    }
}
