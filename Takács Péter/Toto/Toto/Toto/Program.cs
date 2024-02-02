using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines(@"C:\Users\Bálint\Desktop\github\KA_12D.github.io\Takács Péter\Toto\Toto\Toto\bin\Debug\toto.txt");
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
                osszead += database[i].TelitalalatNyeremeny;
            }

            Console.WriteLine("4. feladat: Telitalálatos szelvények száma: {0}", osszead);
            List<double> items = new List<double>();
            for (int i = 0; i < database.Count; i++)
            {
                double temp = database[i].TelitalalatNyeremeny * database[i].TelitalalatNyeremeny;
                if (temp > 0)
                {
                    items.Add(temp);
                }
            }
            double osszeg = items.Sum();
            double atlag = Math.Round(osszeg / database.Count, 0);
            Console.WriteLine("5. feladat: Átlag: {0} Ft", atlag);

            int min = 0;
            int max = 0;
            while (database[min].TelitalalatDb == 0)
            {
                min++;
            }
            for (int i = 0; i < database.Count; i++)
            {
                if (database[min].TelitalalatDb > database[i].TelitalalatDb && database[i].TelitalalatDb != 0)
                {
                    min = i;
                }
                if (database[max].TelitalalatDb < database[i].TelitalalatDb)
                {
                    max = i;
                }
            }
            Console.WriteLine($"6. feladat: \n\tLegnagyobb: \n{database[max]} \n\n\tLegkisebb: \n{database[min]}");
            Console.ReadKey();
        }
    }
}
