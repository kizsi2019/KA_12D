using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int szam = 0;
            bool tryparse = int.TryParse(Console.ReadLine(), out szam);
            if (tryparse) Console.WriteLine(szam);
            else Console.WriteLine("rossz bemenet, hiba! ");
            
            long szam = 0;
            do
            {
                Console.WriteLine("Adja meg a számot: ");
            }
            while (!long.TryParse(Console.ReadLine(), out szam));
            Console.WriteLine(szam);
            
            List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            Console.WriteLine("Kapacitása: " + lista.Capacity);
            Console.WriteLine("Mérete: " + lista.Count);

            List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            List<int> lista = new List<int>();
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            lista.Insert(1, 31);
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            List<int> lista = new List<int>() { 10, 23, 4, 30, 10, 16, 19, 20, 34, 10 };
            lista.Clear();
            Console.WriteLine("Törlés után a kapacitása: {0}, mérete: {1}", lista.Capacity, lista.Count);




            int[] tömb = new int[] { 20, 30, 12 };
            List<int> list = new List<int>();
            list.AddRange(tömb);
            foreach (int i in list) {
                Console.WriteLine(i);
            }
           
            int[] tömb = new int[] { 20, 30, 12 };
            List<int> list = new List<int>() { 10, 24, 32};
            list.InsertRange(2, tömb);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
 
            List<string> list = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi"};
            list.Sort();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            List<string> list = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            if (list.Contains("körte"))
                Console.WriteLine("van körte");

            List<string> list = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            int index = list.IndexOf("körte");
            if (index != -1)
                Console.WriteLine("Van körte, indexe: " + index);
*/
            List<int> lista = new List<int>() { 20, 31, 10};
            int[] tömb = lista.ToArray();












            Console.ReadKey();
        }
    }
}
