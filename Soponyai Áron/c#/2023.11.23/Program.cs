using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2023._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] Tömb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            //int összeg = 0;
            // for (int i = 0; i < Tömb.Length; i++)
            //{
            //    összeg += Tömb[i];
            //}
            //Console.WriteLine(" A tömbben tárolt számmok összege: {0}", összeg); 

            //StreamReader sr = new StreamReader("utak.txt");
            //List<double> utak = new List<double>();
            //while (!sr.EndOfStream)
            //{
            //    utak.Add(double.Parse(sr.ReadLine())); 
            //}
            //sr.Close();
            //double összesút = 0;
            //for(int i =0; i < utak.Count; i++)
            //{
            //    összesút += utak[i];
            //}
            //Console.WriteLine("Az autó ezen a héten összesen {0}km tett meg.", összesút);


            //int[] randT = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < randT.Length; i++)
            //{
            //    randT[i] = r.Next(0, 21);
            //}
            //int j = 0;
            //while (j < randT.Length && randT[j] <= 15)
            //{
            //    j++;
            //}
            //if (j < randT.Length)
            //{
            //    Console.WriteLine( "Van");
            //}
            //else
            //{
            //    Console.WriteLine("nincs");
            //}
            //
            //foreach (in item in randT)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] randT = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < randT.Length; i++)
            //{
            //    randT[i] = r.Next(0, 21);
            //}
            //
            //int db = 0;
            //for (int i = 0; db < randT.Length; db++)
            //{
            //    if (randT[i] % 2 == 0)
            //    { 
            //        db++;
            //    }
            //}
            //
            //Console.WriteLine("A generált tömbben {0}db páros szám van", db);

            //StreamReader sr = new StreamReader("julius.txt");
            //List<double> hő = new List<double>();
            //while (!sr.EndOfStream)
            //    {
            //        hő.Add(double.Parse(sr.ReadLine()));
            //    }
            //int kicsi = 0;
            //
            //for (int i = 0; i < hő.Count; i++)
            //{
            //    if (hő[i] < hő[kicsi]) 
            //    { 
            //        kicsi = i;
            //    }
            //}
            //
            //Console.WriteLine("A legalacsonyabb elem index {0}, értéke {1}", kicsi + 1, hő[kicsi]);

            //StreamReader sr = new StreamReader("végeredmény.txt");
            //List<string> eredmény = new List<string>();
            //while (!sr.EndOfStream)
            //{
            //    eredmény.Add(sr.ReadLine());
            //
            //}
            //sr.Close();
            //
            //Console.WriteLine("Adja meg a versenyző nevét: ");
            //string név = Console.ReadLine();
            //int i = 0;
            //while (i < eredmény.Count && eredmény[i] != név)
            //{
            //    i++;
            //}

            //int[] beolvasás = new int[20];
            //for (int i = 0; i < 20;  i++)
            //{
            //    Console.WriteLine("Adja meg a {0}. számot", i+1);
            //    beolvasás[i] = int.Parse(Console.ReadLine());
            //}
            //
            //int j = 0;
            //while (j < beolvasás.Length && beolvasás[j] % 3 !=0)
            //{
            //    j++;
            //}
            //if (j < beolvasás.Length)
            //{
            //    Console.WriteLine("3mal osztható számot {0}.-ra vitt be!" j+1);
            //}
            //else
            //{
            //    Console.WriteLine("Nem adott meg 3mal osztható számot!");
            //}

            int[] rendezettTömb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83 };
            //Logaritmikus keresés
            int alsóhatár = 0;
            int felsőhatár = rendezettTömb.Length - 1;
            int közép = 0;
            do
            {
                közép = (alsóhatár + felsőhatár) / 2;
                if (rendezettTömb[közép] < 111) alsóhatár = közép + 1;
                if (rendezettTömb[közép] > 111) felsőhatár = közép - 1;
            } while (alsóhatár <= felsőhatár && rendezettTömb[közép] != X);
            if (rendezettTömb[közép] == 111)
                Console.WriteLine("Van, indexe: " + közép);
            else Console.WriteLine("Nincs");







            Console.ReadKey();
            }
        }
    }

