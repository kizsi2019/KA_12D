using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom.Compiler;

namespace nevezetesalgoritmusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int összeg = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                összeg += Tömb[i];
            }
            Console.WriteLine("A tömbben tárolt számok összege: {0}", összeg);
            

            StreamReader sr = new StreamReader("utak.txt");
            List<double> utak = new List<double>();
            while (!sr.EndOfStream)
            {
                utak.Add(double.Parse(sr.ReadLine()));
            }
            sr.Close();
            double osszesut = 0;
            for (int i = 0;  i < utak.Count; i++)
            {
                osszesut += utak[i];
            }
            Console.WriteLine("Az autó ezen a héten összesen {0}km-t tett meg.", osszesut);


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
            if (j < randT.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");


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


            int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int maxindex = 0;
            int minindex = 0;
            for (int i = 0; i < Tömb.Length; i++)
            {
                if (Tömb[i] > Tömb[maxindex]) maxindex = i;
                if (Tömb[i] < Tömb[minindex]) minindex = i;
            }
            Console.WriteLine("A legnagyobb elem indexe {0}, értéke {1}", maxindex, Tömb[maxindex]);
            Console.WriteLine("A legkisebb elem indexe {0}, értéke {1}", minindex, Tömb[minindex]);


            StreamReader sr = new StreamReader("julius.txt");
            List<double> hőmérséklet = new List<double>();
            while(!sr.EndOfStream)
            {
                hőmérséklet.Add(double.Parse(sr.ReadLine()));
            }
            int min = 0;
            for (int i = 0; i < hőmérséklet.Count; i++)
            {
                if (hőmérséklet[i] < hőmérséklet[min]) min = i;
            }
            Console.WriteLine("A legalacsonyabb hőmérséklet {0}-án {1} fok volt", min, hőmérséklet[min]);


            StreamReader sr = new StreamReader("végeredmény.txt");
            List<string> eredmény = new List<string>();
            while(!sr.EndOfStream)
            {
                eredmény.Add(sr.ReadLine());
            }
            sr.Close();
            Console.WriteLine("Adja meg a versenyző nevét: ");
            string név = Console.ReadLine();
            int i = 0;
            while (i < eredmény.Count && eredmény[i] != név)
            {
                i++;
            }
            Console.WriteLine("{0} nevű versenyző {1}. lett", név, i + 1);


            int[] read = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Adja meg a {0}. számot: ", i + 1);
                read[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            while (j < read.Length && read[j] % 3 != 0)
            {
                j++;
            }
            if (j < read.Length) Console.WriteLine("3mal osztható számot {0}.-ra vitt be", j + 1);
            else Console.WriteLine("Nem adott meg 3mal osztható számot");
*/

            int[] rendezettTömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int alsohatar = 0;
            int felsohatar = rendezettTömb.Length - 1;
            int kozep = 0;
            do
            {
                kozep = (alsohatar + felsohatar) / 2;
                if (rendezettTömb[kozep] < 111) alsohatar = kozep + 1;
                if (rendezettTömb[kozep] > 111) felsohatar = kozep - 1;
            }
            while (alsohatar <= felsohatar && rendezettTömb[kozep] != 111);





            Console.ReadKey();
        }
    }
}
