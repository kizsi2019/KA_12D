﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valami_újabb_cucc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tömb = new int[] { 12, 56, 34, 21, 67, 45, 45, 97 };
            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] < Tömb[legkisebb_index]) legkisebb_index = i;
            }
            Console.WriteLine(
             "A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine(
             "A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, Tömb[legkisebb_index]);
        }
    }
}
