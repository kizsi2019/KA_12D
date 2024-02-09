using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdc_cbRadio
{
    class Program
    {
      
        static List<CBClass> lista = new List<CBClass>();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("cb.txt", Encoding.UTF8);
            string sor = sr.ReadLine(); 
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                CBClass cb = new CBClass(sor);
                lista.Add(cb);
            }
            sr.Close();

            Console.WriteLine("3. feladat");
            Console.WriteLine("Bejegyzések száma: " + lista.Count);


            Console.WriteLine("4. feladat");
            bool megvan = false;
            int i = 0;
            while (megvan == false && i < lista.Count)
            {
                if (lista[i].AdasDb == 4)
                {
                    megvan = true;
                    Console.WriteLine("Volt négy adást indító sofőr!");
                }
                i++;
            }
            if (megvan == false) Console.WriteLine("Nem volt négy adást indító sofőr!");

            Console.WriteLine("5. feladat");
            Console.WriteLine("Kérek egy nevet: ");
            string bekertNev = Console.ReadLine();
            int osszAdasDB = 0;
            for (i = 0; i < lista.Count; i++)
            {
                if (lista[i].Nev == bekertNev)
                {
                    osszAdasDB += lista[i].AdasDb;
                }
            }
            if (osszAdasDB == 0)
            {
                Console.WriteLine("Nincs ilyen sofőr!");
            }
            else
            {
                Console.WriteLine($"{bekertNev} {osszAdasDB}x használta a cb rádiót!");
            }

            StreamWriter sw = new StreamWriter("cb2.txt");
            sw.WriteLine("Kezdés;Név;AdasDb");
            for (int j = 0; j < lista.Count; j++)
            {
                sw.WriteLine(lista[j].atSzamolPercre() + ";" + lista[j].Nev
                    + ";" + lista[j].AdasDb);
            }
            sw.Close();

            Console.WriteLine("8. feladat");
            List<string> nevek = new List<string>();
            for (i = 0; i < lista.Count; i++)
            {
                if (!nevek.Contains(lista[i].Nev))
                    nevek.Add(lista[i].Nev);
            }
            Console.WriteLine("Sofőrök száma: " + nevek.Count);

            Console.ReadKey();
        }
    }
}