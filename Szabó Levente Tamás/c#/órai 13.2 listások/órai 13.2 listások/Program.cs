using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_13._2_listások
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {10,23,4};
            list.Remove(23);
            List<int> list2 = new List<int>() {10,23,4,30};
            list2.RemoveAt(2);
            Console.ReadKey();
        }
    }
}
