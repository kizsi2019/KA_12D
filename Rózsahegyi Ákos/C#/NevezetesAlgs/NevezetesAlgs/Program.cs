using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevezetesAlgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while (i < Tomb.Length && Tomb[i] != 1)
            {
                i++;
            }
            if (i < Tomb.Length) Console.WriteLine($"A '1' feltételnek megfelelő elem sorszáma {i}");
            else Console.WriteLine("Nincs");
            Console.ReadKey();


            /* Összegzés tétele
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int összeg = 0;
            for (int i = 0; i < Tomb.Length; i++)
            {
                összeg += Tomb[i];
            }
            Console.WriteLine("A tömbben tárolt számok összege: {0}", összeg);
            Console.ReadKey();

            // Összegzés példa
            StreamReader sr= new StreamReader(@"C:\Users\RozsahegyiAkos\Desktop\Github\KA_12D.github.io\Rózsahegyi Ákos\C#\NevezetesAlgs\NevezetesAlgs\bin\Debug\utak.txt");
            List<double> utak = new List<double>();
            while (!sr.EndOfStream )
            {
                utak.Add(double.Parse(Console.ReadLine()));
            }
            sr.Close();

            double osszeg = 0;
            for (int i = 0; i < utak.Count; i++)
            {
                osszeg += utak[i];
            }
            Console.WriteLine($"Az autó ezen a héten összesen {osszeg}km tett meg.");
            Console.ReadKey();

            // Eldöntés tétele
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while (i < Tomb.Length && Tomb[i] != 9)
            {
                i++;
            }
            if (i < Tomb.Length) Console.WriteLine("Van");
            else Console.WriteLine("Nincs");
            Console.ReadKey();
            */

            /* Eldöntés példa
            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            foreach (int item in randT)
            {
                Console.Write(item + " ");
            }
            int j = 0;
            while (j < randT.Length && randT[j] <= 15)
            {
                j++;
            }
            if (j < randT.Length) Console.WriteLine("\nVan");
            else Console.WriteLine("\nNincs");
            Console.ReadKey(); */

            /* Megszámlálás tétele
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int db = 0;
            for (int i = 0; i < Tomb.Length; i++)
            {
                if (Tomb[i] <= 10) db++;
            }
            Console.WriteLine($"Feltételnek megfelelő elem száma: {db}db");
            Console.ReadKey();

            // Megszámlálás példa
            int[] randT = new int[10];
            Random r = new Random();
            for (int i = 0; i < randT.Length; i++)
            {
                randT[i] = r.Next(0, 21);
            }
            foreach (int item in randT)
            {
                Console.Write(item + " ");
            }
            int db = 0;
            for (int i = 0; i < randT.Length; i++)
            {
                if (randT[i] % 2 == 0) db++;
            }
            Console.WriteLine($"\nA generált tömbben {db}db páros szám van");
            Console.ReadKey();*/

            /* Maximum/Minimum kiválasztás tétele
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int legkisebb = 0;
            int legnagyobb = 0;
            for (int i = 0; i < Tomb.Length; i++)
            {
                if (Tomb[i] < Tomb[legkisebb]) legkisebb = i;
                if (Tomb[i] > Tomb[legnagyobb]) legnagyobb = i;
            }
            Console.WriteLine($"Legkisebb elem indexe: {legkisebb}");
            Console.WriteLine($"Legnagyobb elem indexe: {legnagyobb}");
            Console.ReadKey();*/

            /* Max/Min példa
            StreamReader sr = new StreamReader("julius.txt");
            List<double> homerseklet = new List<double>();
            while (!sr.EndOfStream)
            {
                homerseklet.Add(double.Parse(sr.ReadLine()));
            }
            int legalacsonyabb = 0;
            for (int i = 0; i < homerseklet.Count; i++)
            {
                if (homerseklet[i] < homerseklet[legalacsonyabb]) legalacsonyabb = i;
            }
            Console.WriteLine($"A legalacsonyabb hőmérséklet {legalacsonyabb + 1}.-án/én {homerseklet[legalacsonyabb]} fok volt!");
            Console.ReadKey();*/

            /* Kiválasztás tétele
            int[] Tomb = new int[] { 32, 12, 10, 9, 45, 90, 13, 8, 1, 42 };
            int i = 0;
            while (i < Tomb.Length && Tomb[i] != 9)
            {
                i++;
            }
            Console.WriteLine($"A 'Feltétel' feltételnek megfelelő elem sorszáma {i}");
            Console.ReadKey();*/
            

            /* Kiválasztás példa
            StreamReader sr = new StreamReader("vegeredmeny.txt");
            List<string> eredmeny = new List<string>();
            while (!sr.EndOfStream)
            {
                eredmeny.Add(sr.ReadLine());
            }
            sr.Close();
            Console.Write("Adja meg a versenyző nevét: ");
            string nev = Console.ReadLine();
            int i = 0;
            while (i < eredmeny.Count && eredmeny[i] != nev)
            {
                i++;
            }
            Console.WriteLine($"{nev} nevű versenyző {i+ 1}. lett");
            Console.ReadKey();*/

            //Keresés tétele
            

            /* Keresés példa
            int[] beolvasas = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Adja meg a {i + 1}. számot: ");
                beolvasas[i] = int.Parse(Console.ReadLine());
            }
            int j = 0;
            while (j < beolvasas.Length && beolvasas[j] % 3 != 0)
            {
                j++;
            }
            if (j < beolvasas.Length) Console.WriteLine($"3-mal osztható számot {j + 1}.-ra vitt be!");
            else Console.WriteLine("Nem adott meg 3-mal osztható számot!");
            Console.ReadKey();*/
            

            /* Logaritmikus keresés tétele
            int[] rendezettTomb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83 };
            int alsohatar = 0;
            int felsohatar = rendezettTomb.Length - 1;
            int kozep = 0;
            do
            {
                kozep = (alsohatar + felsohatar) / 2;
                if (rendezettTomb[kozep] < 111) alsohatar = kozep + 1;
                if (rendezettTomb[kozep] > 111) felsohatar = kozep - 1;
            } while (alsohatar <= felsohatar && rendezettTomb[kozep] != 111);
            if (rendezettTomb[kozep] == 111)
                Console.WriteLine("Van, indexe: " + kozep);
            else Console.WriteLine("Nincs");
            Console.ReadKey();*/
        }
    }
}
