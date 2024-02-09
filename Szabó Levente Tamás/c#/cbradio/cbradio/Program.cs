using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace cbradio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sor> sorok = new List<Sor>();
            foreach (var i in File.ReadAllLines("cb.txt").Skip(1))
            {
                sorok.Add(new Sor());
            }
            Console.WriteLine($"Összesen " + sorok.Count + " sor található meg");
            int bejegyzes = sorok.Count -1;
            foreach (var i in sorok)
            {
                bejegyzes = sorok.Count -1;
            }
            Console.WriteLine($"A bejegyzések száma: " + bejegyzes);
            bool van = false;
            int a = 0;
            while(van == false && a < sorok.Count)
            {
                if (sorok[a].AdasDb == 4)
                {
                    van = true;
                    Console.WriteLine("Volt idő amikor 4 adást indítottak");
                    a++;
                }
                else
                {
                    Console.WriteLine("Olyan idő nem volt amikor 4 adást indítottak.");
                    a++;
                }
            }
            Console.ReadKey();
        }
    }
}
