using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevezets_algoritmusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int osszeg = 0;
            for (int i = 0; i < Tomb.Length; i++)
            {
                osszeg += Tomb[i];
            }

            Console.WriteLine("A tömben tárolt számok összege: {0}", osszeg); */

            /*
            StreamReader sr = new StreamReader("utak.txt");
            List<double> utak = new List<double>();
            while (!sr.EndOfStream)
            {
                utak.Add(double.Parse(sr.ReadLine()));
            }
            sr.Close();
            double osszesut = 0;
            for (int i = 0; i < utak.Count; i++)
            {
                osszesut += utak[i];
            }
            Console.WriteLine("Az autó ezen a héten összesen {0}km tett meg", osszesut);
            */

            /*
            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            foreach (int i  in randT)
            {
                Console.Write(i +  " ");
            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j < randT.Length) Console.Write("\nVan");
            else Console.WriteLine("Nincs");
            */
            /*
            int[] randT = new int[10];
            Random r = new Random();
  
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            
            int db = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine("A generált tömbben {0}db páros szám van", db);
            */

            /*
            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legnagyobb_index = 0;
            int legkisebb_index = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > Tömb[legnagyobb_index]) legnagyobb_index = i;
                if (Tömb[i] < Tömb[legkisebb_index]) legkisebb_index = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", legnagyobb_index, Tömb[legnagyobb_index]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", legkisebb_index, Tömb[legkisebb_index]);
            */

            
            StreamReader sr = new StreamReader("július.txt");
            List<double> hőmérséklet = new List<double>();
            while (!sr.EndOfStream)
            {
                hőmérséklet.Add(double.Parse(sr.ReadLine()));
            }
            sr.Close();
            int legalacsonyabb_i = 0;
            for (int i = 0; i < hőmérséklet.Count; i++)
            {
                if (hőmérséklet[i] < hőmérséklet[legalacsonyabb_i]) legalacsonyabb_i = i;
            }
            Console.WriteLine("A legalacsonyabb hőmérséklet {0}.-án {1} fok volt!", legalacsonyabb_i + 1,
            hőmérséklet[legalacsonyabb_i]); 


            /*
            StreamReader sr = new StreamReader("végeredmény.txt");
            List<string> eredmény = new List<string>();
            while (!sr.EndOfStream)
            {
                eredmény.Add(sr.ReadLine());
            }
            sr.Close();
            Console.Write("Adja meg a versenyző nevét: ");
            string név = Console.ReadLine();
            int i = 0;
            while (i < eredmény.Count && eredmény[i] != név)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. lett", név, i + 1);
            */

            /*
            int[] beolvasás = new int[20];
            for (int i = 0; i < 20; i++)
            { //bekérés a felhasználótól
                Console.Write("Adja meg a {0}. számot: ", i + 1);
                beolvasás[i] = int.Parse(Console.ReadLine());
            }
            //Keresés tétele
            int j = 0;
            while (j < beolvasás.Length && beolvasás[j] % 3 != 0)
            {
                j++;
            }
            if (j < beolvasás.Length) Console.WriteLine("3mal osztható számot {0}.-ra vitt be!", j + 1);
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");
            */

            int[] rendezettTömb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83, 111 };

            int alsohatar = 0;
            int felsohatar = rendezettTömb.Length - 1;
            int kozep = 0;
            do
            {
                kozep = (alsohatar + felsohatar) / 2;
                if (rendezettTömb[kozep] < 25) alsohatar = kozep + 1;
                if (rendezettTömb[kozep] > 25) felsohatar = kozep - 1;
            } while (alsohatar <= felsohatar && rendezettTömb[kozep] != 25);
            if (rendezettTömb[kozep] == 25)
                Console.WriteLine("Van, indexe: " + kozep);
            else Console.WriteLine("Nincs");

            Console.ReadKey();

           
        }
    }
}
