﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int szam = 0;
            bool tryparse = int.TryParse(Console.ReadLine(), out szam);
            if (tryparse) Console.WriteLine(szam);
            else Console.WriteLine("Rossz bemenet, hiba!");
            Console.ReadKey();

            long szam = 0;
            do
            {
                Console.Write("Adja meg a számot: ");
            } while (!long.TryParse(Console.ReadLine(), out szam));
            Console.WriteLine(szam);
            Console.ReadKey();

            List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            Console.WriteLine("Kapacítása: " + lista.Capacity);
            Console.WriteLine("Mérete: " + lista.Count);
            Console.ReadKey();

            List<int> lista = new List<int>(8);
            lista.Add(12);
            lista.Add(43);
            lista.Add(2);
            
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();

            foreach (int item in lista)
            {
                Console.Write(item + "! ");
            }
            Console.ReadKey();
            

            // List.Insert(hova, mit)
            List<int> lista = new List<int>();
            lista.Add(12); lista.Add(43); lista.Add(2);
            lista.Insert(1, 31);
            foreach (int item in lista)
            {
                Console.Write(item);
            }
            Console.ReadKey();

            // List.Remove(mit)
            List<int> lista2 = new List<int>() { 10, 23, 4 };
            lista2.Remove(23);
            foreach (int item in lista2)
            {
                Console.Write(item);
            }
            Console.ReadKey();

            // List.RemoveAt(index)
            List<int> lista3 = new List<int>() { 10, 23, 4, 30 };
            lista3.RemoveAt(2);
            foreach (int item in lista3)
            {
                Console.Write(item);
            }
            Console.ReadKey();

            // List.Clear()
            List<int> lista4 = new List<int>() { 10, 23, 4, 30, 10, 16, 19, 20, 34, 10 };
            lista4.Clear();
            Console.WriteLine("Törlés után a kapacitása: {0}, mérete: {1}", lista4.Capacity, lista4.Count);
            Console.ReadKey();

            // List.AddRange(kollekció)
            int[] tomb = new int[] { 20, 30, 12 };
            List<int> lista5 = new List<int>();
            lista5.AddRange(tomb);
            Console.ReadKey();

            // List.InsertRange(index, kollekció)
            int[] tomb2 = new int[] { 20, 30, 12 };
            List<int> lista6 = new List<int>() { 10, 24, 32 };
            lista6.InsertRange(2, tomb2);
            Console.ReadKey();

            // List.Sort()
            List<string> lista7 = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            lista7.Sort();
            foreach (string item in lista7)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            // List.Contains(elem)
            List<string> lista8 = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            if (lista8.Contains("körte")) Console.WriteLine("Van körte");
            Console.ReadKey();

            // List.IndexOf(keresett elem) /LastIndexOf
            List<string> lista9 = new List<string>() { "banán", "alma", "körte", "narancs", "kiwi" };
            int index = lista9.IndexOf("körte");
            if (index != -1) Console.WriteLine("Van körte, indexe: " + index);
            Console.ReadKey();
            

            // T[] = List.ToArray()
            List<int> lista10 = new List<int>() { 20, 31, 10 };
            int[] tomb3 = lista10.ToArray();
            foreach (int item in tomb3)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
