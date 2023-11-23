using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int szam = 0;
            bool tryparse = int.TryParse(Console.ReadLine(), out szam);
            if (tryparse) Console.WriteLine(szam);
            else Console.WriteLine("Rossz bemenet, HIBA!");*/

            long szam = 0;
            do 
            {
                Console.Write("Adja meg a számot: ");            
            }
            while (!long.TryParse(Console.ReadLine(), out szam));
            Console.WriteLine(szam);

            /*List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            Console.WriteLine("Kapacitása: " + lista.Capacity);
            Console.WriteLine("Mérete: " +lista.Count);

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
            foreach (item in lista)
            {
                Console.WriteLine(item);
            }

            List<int> lista = new List<int>();
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            lista.Insert(1, 31);

            List<int> lista = new List<int>() { 10, 23, 4 };
            lista.Remove(23);

            List<int> lista = new List<int>() { 10, 23, 4, 30};
            lista.RemoveAt(2);

            List<int> lista = new List<int>() { 12, 23, 4, 10, 16, 19, 34, 10};
            lista.Clear();
            Console.WriteLine("Törlés után a kapacitása: {0}, mérete: {1}", lista.Capacity, lista.Count);

            int[] tömb = new int[] { 20, 30, 12 };
            List<int> lista = new List<int>();
            lista.AddRange(tömb);

            int[] tömb = new int[] { 20, 30, 12 };
            List<int> lista = new List<int>() { 10, 24, 32};
            lista.InsertRange(2, tömb);
            foreach (int i in lista) 
            {
                Console.WriteLine(i);
            }

            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi"};
            lista.Sort();
            foreach (string item in lista) 
            {
                Console.WriteLine(item);
            }

            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            if (lista.Contains("körte")) Console.WriteLine("Van körte");

            List<string> lista = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            int index = lista.IndexOf("körte");
            if (index != -1) Console.WriteLine("Van körte, indexe: ", index);

            List<int> lista = new List<int>() { 20, 30, 10};
            int[] tömb = lista.ToArray();
            foreach (int item in tömb)
            {
                Console.WriteLine(item);
            }*/

            Console.ReadKey();
        }
    }
}
