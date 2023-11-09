using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valamiscuccos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int szam = 0;
             bool tryparse = int.TryParse(Console.ReadLine(), out szam);
             if (tryparse) Console.WriteLine(szam);
             else Console.WriteLine("Roszz Bemenet");*/
            /*long szam = 0;
            do
            {
                Console.WriteLine("adja meg a számot:");

            } while (!long.TryParse(Console.ReadLine(), out szam);
            Console.WriteLine(szam);*/
            /*List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            Console.WriteLine("kapacítása "+lista.Capacity);
            Console.WriteLine("méret"+ lista.Count);
            Console.ReadKey();*/
            /*List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            for( int i = 0; i < lista.Count; i++ )
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();*/
            /*List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            foreach (int i in lista);
            {
                Console.WriteLine(i);
            }*/
            /*List<int> lista = new List<int>();
            lista.Add(12); lista.Add(42);lista.Add(2);
            lista.Insert(1, 31);*/

            /* int[] tömb = new int[] { 20, 30, 12 };
             List<int> list = new List<int>() {10,24,32 };
             lista.InsertRange(2, tömb);*/

            /* List<string> list = new List<string>() { "banán","alma","körte","narancs"};
             list.Sort();
             foreach (string item in list)
             {
                 Console.WriteLine(item);
             }*/

            /* List<string> list = new List<string>() { "banán", "alma", "körte", "narancs" };
             int index = list.IndexOf("körte");
             if (index != -1 ) Console.WriteLine("van körte,indexe:" + index);*/

            List <int> = new List<int>() { 20, 30, 12 };
            int[] tömb = List.Toarray();
            Console.ReadKey();


        }
    }
}
