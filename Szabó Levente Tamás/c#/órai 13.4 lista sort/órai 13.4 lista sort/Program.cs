using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_13._4_lista_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"banán","alma","körte","narancs","kiwi"};
            list.Sort();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            if (list.Contains("körte")) Console.WriteLine("Van körte");
            int index = list.IndexOf("körte");
            if (index != -1) Console.WriteLine("Van körte, indexe:" + index);
            Console.ReadKey();
        }
    }
}