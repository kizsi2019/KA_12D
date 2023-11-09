using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int szam = 0;
            bool tryparse = int.TryParse(Console.ReadLine(), out szam);
            if (tryparse) Console.WriteLine(szam);
            else Console.WriteLine("Rossz bemenet, hiba!");
            Console.ReadKey();

            long szam = 0;
            do
            {
                Console.Write("Adja meg a szamot: ");
            }
            while (!long.TryParse(Console.ReadLine(), out szam));
            Console.WriteLine(szam);
            

            List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            Console.WriteLine("Kapacitása: " + lista.Capacity);
            Console.WriteLine("Mérete: " + lista.Count);
            foreach (int item in lista) 
            {
                Console.WriteLine(item);
            }


            List<int> lista = new List<int>() { 10, 23, 4, 30, 10, 16, 19, 20, 34, 11};
            lista.Clear();
            Console.WriteLine("Törlés utáni kapacitás: {0}, méret: {1}", lista.Capacity, lista.Count);


            int[] tömb = new int[] { 20, 30, 12 };
            List<int> lista = new List<int>() { 10, 24, 32};
            lista.InsertRange(2, tömb);


            List<string> lista = new List<string>() { "banan", "alma", "korte", "narancs", "kiwi"};
            lista.Sort();
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }


             { "banan", "alma", "korte", "narancs", "kiwi"}
            if (lista.Contains("korte"))
                Console.WriteLine("Van korte");


            List<string> lista = new List<string>() { "banan", "alma", "korte", "narancs", "kiwi" };
            int index = lista.IndexOf("korte");
            if (index != -1 )
            {
                Console.WriteLine("van korte, indexe: " + index);
            }
*/

            List<int> lista = new List<int>() { 20, 31, 10};
            int[] tömb = lista.ToArray();
            foreach( int item in tömb )
            {
                Console.WriteLine(item);
            }






            Console.ReadKey();

        }
    }
}
