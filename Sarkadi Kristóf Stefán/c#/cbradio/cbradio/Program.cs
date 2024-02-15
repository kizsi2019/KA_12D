using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cbradio
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Radio> radio = new List<Radio>();
            foreach (var sor in File.ReadLines("cb.txt").Skip(1))
            {
                radio.Add(new Radio(sor));
            }

            //3.feladat
            Console.WriteLine($"3. feladat: Bejegyzések száma: {radio.Count}db");

            //4.feladat
            int sofotdb = radio.First().AdasDb;
            foreach (var item in radio)
            {
                if (item.AdasDb > sofotdb)
                {
                    sofotdb = item.AdasDb;
                }
            }
            Console.WriteLine($"5. feladat: Volt {sofotdb} adás indító sofőr");

            //5.feladat
            Console.WriteLine("5. feladat: Kérek egy nevet:");
            string vnev = radio.First().Nev;
            foreach (var item in radio)
            {
                if (item.Nev == vnev)
                {
                    vnev = item.Nev;
                    Console.WriteLine($"\t{vnev}{vnev.Count()}x használta a CB-rádiót!");
                }
            }

            //6.feladat


            //8.feladat


            //9.feladat


            Console.ReadKey();
        }
    }
}
