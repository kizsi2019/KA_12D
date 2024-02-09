using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cbRadio
{
    class Program
    {
        static List<CBClass> lista = new List<CBClass>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("cb.txt");
            string sor = sr.ReadLine();
            while (!sr.EndOfStream) 
            {
                sor = sr.ReadLine();
                CBClass cb = new CBClass(sor);
                lista.Add(cb);
            }
            sr.Close();
            //3.Feladat
            Console.WriteLine("Ennyi bejegyzés van:  " + lista.Count);
            //4.Feladat
            bool megvan = false;
            int i = 0;
            while (megvan == false && i < lista.Count) 
            { 
                if (lista[i].AdasDb == 4)
                {
                    megvan = true;
                    Console.WriteLine("volt négy adást indító sofőr");
                }
                i++;
            }
            if (megvan == false)
            {
                Console.WriteLine("nincsen ilyen adás");
            }

            //5.feladat
            Console.WriteLine("Kérem egy sofőr nevét: ");
            string nev = Console.ReadLine();
            int osszAdasDb = 0;
            for (i = 0; i < lista.Count ; i++)
            {
                if (lista[i].Nev == nev)
                {
                    osszAdasDb += lista[i].AdasDb;
                }
            }  
            if (osszAdasDb == 0) 
            {
                Console.WriteLine("nincs ilyen sofor");
            }
            else
            {
                Console.WriteLine("a sofor hívásai:  " + osszAdasDb);
            }

            StreamWriter sw = new StreamWriter("cb2.txt");
            sw.WriteLine("Kezdés;Név;Adásdb");
            for (int j = 0;j < lista.Count ; j++)
            {
                sw.WriteLine(lista[j].atSzamolPercre() + ";" + lista[j].Nev + ";" + lista[j].AdasDb);
            }
            sw.Close();

            Console.WriteLine("");

           List<string>nevek = new List<string>();
            for (i=0; i < lista.Count ;i++) 
            {
                if (!nevek.Contains(lista[i].Nev) )
                    nevek.Add(lista[i].Nev);
                
            }
            Console.WriteLine("sofőrök száma: " + nevek.Count);

            int maxAdasDb = lista[0].AdasDb;
            int maxIndex =0;
            for (i = 0; i < lista.Count; i++) 
            { 
                if (lista[i].AdasDb > maxAdasDb)
                {
                    maxAdasDb = lista[i].AdasDb;
                    maxIndex = i;
                }
            }
            Console.WriteLine("a sofor neve:  " + lista[maxIndex].Nev);
            Console.WriteLine("Adások száma: " + maxAdasDb);




            Console.ReadKey();
        }
    }
}
