using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace cbradio
{
    internal class Program
    {
        static List<Adat> List = new List<Adat>();
        static void Main(string[] args)
        {
            
            StreamReader sr = new StreamReader("cb.txt");
            string sor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                Adat cb = new Adat(sor);
                List.Add(cb);
            }
            sr.Close();
            //3. feladat
            Console.WriteLine("3. feladat: Bejegyzések száma: " + List.Count + " db");
            //4. feladat
            bool megvan = false;
            int i = 0;
            while(megvan == false && i < List.Count)
            {
                if (List[i].AdasDb == 4)
                {
                    megvan = true;
                    Console.WriteLine("4. Feladat: Volt négy adást indító sofőr.");

                }
                i++;
            }
            if (megvan == false)  
            {
                Console.WriteLine("Nem volt senkise xd");
            }
            //5. feladat
            Console.WriteLine("5. feladat: Kérek egy nevet: ");
            string nev = Console.ReadLine();
            int xy = 0;
            for (i = 0; i < List.Count; i++)
            {
                if (List[i].Nev == nev)
                {
                    xy += List[i].AdasDb;
                }
            }
            if (xy == 0)
            {
                Console.WriteLine("Nincs ilyen sofőr");
            }
            else
            {
                Console.WriteLine(nev + xy + "x használta a CB-rádiót" );
            }

            Console.ReadKey();
        }
    }
}
