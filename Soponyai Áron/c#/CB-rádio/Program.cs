using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CB_rádio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Radio> radiolist = new List<Radio>();
            foreach (var sor in File.ReadLines("cb.txt").Skip(1)) 
            {
                radiolist.Add(new Radio(sor));
            }

            //3. feladat

            Console.WriteLine("3.feladat: " + radiolist.Count);

            //4.feladat

            bool inditas4 = false;
            int i = 0;
            while (inditas4 == false && radiolist.Count > i) 
            {
                if (radiolist[i].AdasDB == 4)
                {
                    inditas4 = true;
                    Console.WriteLine("4. feladat: Volt négy adást indító sofőr.");
                }
                i++;
            }

            //5. feladat

            Console.WriteLine("5. feladat: Adj meg egy nevet!");
            string nev = Console.ReadLine();
            int hanyszor = 0;
            for (i = 0; i < radiolist.Count; i++)
            {
                if (radiolist[i].Nev == nev)
                {
                    hanyszor += radiolist[i].AdasDB;
                }
            }
            if (hanyszor == 0)
            {
                Console.WriteLine("Nincs ilyen nevű sofőr!");
            }
            else
            {
                Console.WriteLine($"{nev} {hanyszor}x használta a CB-Radiot.");
            }

            //7. feladat

            StreamWriter textfile = new StreamWriter("cb2.text");
            textfile.WriteLine("Kezdes;Nev;AdasDB");
            for (i = 0; i < radiolist.Count; i++)
            {
                textfile.WriteLine(radiolist[i].AtszamolPercre() +  ';' + radiolist[i].Nev + ';' + radiolist[i].AdasDB);
            }
            textfile.Close();

            //8. feladat

            List<string> neveklist = new List<string>();
            for (i = 0;i < radiolist.Count;i++)
            {
                if (!neveklist.Contains(radiolist[i].Nev)) neveklist.Add(radiolist[i].Nev);
            }
            Console.WriteLine($"8 feladat: Sofőrök száma: {neveklist.Count}");

            //9. feladat
            List<int> hivasok = new List<int>();
            for (i = 0; i < neveklist.Count; i++) 
            {
                int osszhiv = 0;
                for (int j = 0; j < radiolist.Count; j++)
                {
                    if (neveklist[i] == radiolist[j].Nev)
                    {
                        osszhiv += radiolist[j].AdasDB;
                    }
                }
                hivasok.Add(osszhiv);
            }

            Console.WriteLine("9. feladat: A legtöbb adást indító sofőr:");

            for (i = 0; i  < hivasok.Count; i++)
            {
                if (hivasok[i] == hivasok.Max())
                {
                    Console.WriteLine($"Név : {neveklist[i]}");
                }
            }
            Console.WriteLine($"Hívások száma : {hivasok.Max()}");





            Console.ReadKey();
        }
    }
}
