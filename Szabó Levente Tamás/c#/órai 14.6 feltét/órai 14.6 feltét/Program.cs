using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_14._6_feltét
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] beolvasás = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Adja meg a {0} számot: ", i + 1);
                beolvasás[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            while (j < beolvasás.Length && beolvasás[j] % 3 != 0)
            {
                j++;
            }
            if (j < beolvasás.Length) Console.WriteLine("3-mmal osztató számot {0}-ra vitte be", j + 1);
            else Console.WriteLine("Nem adott meg 3-al osztható számot");
            Console.ReadKey();
        }
    }
}
