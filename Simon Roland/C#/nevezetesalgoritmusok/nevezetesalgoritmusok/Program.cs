using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace nevezetesalgoritmusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* StreamReader sr = new StreamReader("utak.txt");
             List<double> utak = new List<double>();
             while (!sr.EndOfStream) { utak.Add(double.Parse(sr.ReadLine())); }
             sr.Close();
             double all = 0;
             for (int i = 0; i < utak.Count; i++) { all += utak[i]; }
             Console.WriteLine("Az autó ezen a héten összesen {0}km tett meg. ", all);
             Console.ReadKey();
             
            int[] randT = new int[10];
            Random r = new Random();
            for(int i = 0; i < randT.Length; i++) 
            {
                randT[i] = r.Next(0, 21);
            }
            foreach(int item in randT) 
            {
                Console.WriteLine(item); 
            }
            int j = 0;
            while(j < randT.Length && randT[j] <= 15) 
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("van");
            else Console.WriteLine("nincs");
            
            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            foreach (int item in randT)
            {
                Console.WriteLine(item);
            }
            int db = 0;
            for (int i = 0; i < randT.Length;i++) 
            {
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van ", db);
            
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int biggest_index = 0;
            int smallest_index = 0;
            for (int i = 0; i < Tömb.Length; i++) 
            {
                if (Tömb[i] > Tömb[biggest_index]) biggest_index = i;
                if (Tömb[i] < Tömb[smallest_index]) smallest_index = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1} ", biggest_index, Tömb[biggest_index]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", smallest_index, Tömb[smallest_index]);
           
            StreamReader sr = new StreamReader("július.txt");
            List<double> temp = new List<double>();
            while (!sr.EndOfStream) 
            {
                temp.Add(double.Parse(sr.ReadLine()));
            }
            int smallest_i = 0;
            for (int i  = 0; i < temp.Count; i++)
            {
                if (temp[i] < temp[smallest_i]) smallest_i = i;
            }
            Console.WriteLine(" A legalacsonyabb hőmérséklet {0}.-án {1} fok volt", smallest_i + 1, temp[smallest_i]);
             
            StreamReader sr = new StreamReader("végeredmény.txt");
            List<string> eredmeny = new List<string>();
            while(!sr.EndOfStream)
            {
                eredmeny.Add(sr.ReadLine());
            }
            sr.Close();
            Console.WriteLine("Adja meg a versenyző nevét: ");
            string name = Console.ReadLine();
            int i = 0;
            while(i < eredmeny.Count && eredmeny[i] != name)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. helyezett lett", name, i + 1 );
            
            int[] read = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Adja mega {0}. számot: ", i + 1 );
                read[i] = int.Parse(Console.ReadLine());
            }

            int j = 0;
            while(j < read.Length && read[j] % 3 != 0) 
            {
                j++;
            }

            if (j < read.Length) Console.WriteLine("3-al osztható számot {0}.-ra vitt be ", j + 1);
            else Console.WriteLine("Nem adott meg 3-al osztható számot!");
            */

            int[] rendezettTömb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83 };
            int alsohatar = 0;
            int felsohatar = rendezettTömb.Length - 1;
            int kozep = 0;
            do
            {
                kozep = (alsohatar + felsohatar) / 2;
                if (rendezettTömb[kozep] < X) alsohatar = kozep + 1;
                if (rendezettTömb[kozep] > X) felsohatar = kozep - 1;
            }
            while (alsohatar <= felsohatar && rendezettTömb[kozep] != X);
            if (rendezettTömb[kozep] == X)
                Console.WriteLine("Van, indexe: " + kozep);
            else Console.WriteLine("Nincs");

            Console.ReadKey();

        }
    }
}
