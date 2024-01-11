using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace összegzes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 8, 1, 42 };
            int összeg = 0;
            for (int i = 0; i < Tömb.Length; i++) 
            {
                összeg++;
            }
            Console.WriteLine("A tömbben tárolt számok összege: {0}", összeg);

            Streamreader sr = new Streamreader("utak.txt");
            List<double> utak = new List<double>();
            while (sr.Read()) 
            { 
                utak.Add(double.Parse(sr.ReadLine()));
            }
            sr.Close();
            double osszesut = 0;
            for (int i = 0; i < utak.Count; i++) 
            { 
                osszesut+= utak[i];
            }
            Console.WriteLine("Az autó ezen a héten összesen {0}km tett meg.", osszesut);

            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++) 
            {
                randT[i] = r.Next(0, 23);
            }
            int j = 0;
            while (j < randT.Length) 
            { 
                j++;
            }
            if (j == randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");

            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j == randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");

            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            int db = 0;
            for (int i = 0;i < randT.Length; i++)
            {
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("A generát tombben {0}db szám van", db);

            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] < Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] < Tömb[legkisebb_index]) legkisebb_index = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, Tömb[legkisebb_index]);

            StreamReader sr = new StreamReader("julius.txt");
            List<double> hőmérséklet = new List<double>();
            while (!sr.EndOfStream)
            {
                hőmérséklet.Add(double.Parse(sr.ReadLine()));
            }
            int legalacsonyabb_i = 0;
            for (int i = 0; i < legalacsonyabb_i; i++)
            {
                if (hőmérséklet[i] < hőmérséklet[legalacsonyabb_i]) legalacsonyabb_i = i;
            }
            Console.WriteLine("A legalacsonyabb hőméséklet {0}.-án {1} fokvolt", legalacsonyabb_i);

            StreamReader sr = new StreamReader("végeredmény.txt");
            List<string> eredmeny = new List<string>();
            while (sr.EndOfStream)
            {
                eredmeny.Add(sr.ReadLine());
            }
            sr.Close();
            Console.Write("Adja meg a versenyző nevét: ");
            string név = Console.ReadLine();
            int i = 0;
            while (i < eredmeny.Count && eredmeny[i] != név)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}, lett", név, i + 1);

            int[] beolvasás = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Adja meg a {0}. számot: ", i + 1);
                beolvasás[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            while (j < beolvasás.Length && beolvasás[j] % 3 != 0) 
            { 
                j++;
            }
            if (j < beolvasás.Length) Console.WriteLine("3-mal osztható számot {0}.-ra vitt be!", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");*/

            int[] Tömb = new int[] { 10, 15, 10, 31, 111 };
            int alsohatar = 0;
            int felsohatar = Tömb.Length - 1;
            int kozep = 0;
            do
            {
                kozep = (alsohatar + felsohatar) / 2;
                if (Tömb[kozep] < 15) alsohatar = kozep + 1;
                if (Tömb[kozep] > 15) felsohatar = kozep - 1;
            } while (alsohatar <= felsohatar && Tömb[kozep] != 15);
            if (Tömb[kozep] == 15) Console.WriteLine("Van indexe: ", kozep);
            else Console.WriteLine("Nincs");

            Console.ReadKey();
        }
    }
}
