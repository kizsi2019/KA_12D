using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_13._5_toarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {20,31,10};
            int[] tömb = list.ToArray();
            Console.ReadKey();
        }
    }
}
