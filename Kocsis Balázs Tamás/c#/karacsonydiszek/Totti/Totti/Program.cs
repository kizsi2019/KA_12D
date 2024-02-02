using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Totti;
using System.ComponentModel;

namespace Totti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("toto.txt");
            List<Fordulo> database = new List<Fordulo>();
            for (int i = 1; i < inputs.Length; i++)
            {
                Fordulo temp = new Fordulo(inputs[i]);
                database.Add(temp);
            }
            Console.WriteLine("3. feladat: Fordulók száma: {0}", database.Count);

            double osszead = 0;
            for (int i = 0; i < database.Count; i++)
            {
                osszead += database[i].Telidb;
            }
            Console.WriteLine("4.feladat: Telitalálat {0}db volt", osszead);

            List<double> items = new List<double>();
            for (int i = 0; i < database.Count; i++)
            {
                double x = database[i].Telidb * database[i].TeliNyer;
                if (x > 0)
                {
                    items.Add(x);
                }
            }
            double osszeg = items.Sum();
            double atlag = Math.Round(osszeg / database.Count, 0);
            Console.WriteLine("5.feladat: Átlag: {0} Ft", atlag);

            int min = 0;
            int max = 0;
            while (database[min].Telidb == 0)
            {

            }
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].Telidb > database[i].TeliNyer && database[i].TeliNyer != 0)
                {
                    min = i;
                }
                if (database[max].Telidb < database[i].TeliNyer)
                {
                    max = i;
                }
            }

            Console.WriteLine($"6. feladat: Legnagyobb: {database[max]}, legkisebb: {database[min]}");
            Console.ReadKey();

        }
    }
}
