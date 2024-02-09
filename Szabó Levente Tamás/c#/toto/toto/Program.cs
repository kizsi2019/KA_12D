using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] toto = File.ReadAllLines("toto.txt");
            using (StreamReader reader = new StreamReader("toto.txt"))
            {
                int lineCount = 0;

                // Skip the first line
                reader.ReadLine();

                // Count the remaining lines
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
                Console.WriteLine($"3. feladat: fodulók száma: {lineCount}");
            }

            int teliTalalt = 0;
            foreach (string line in toto)
            {
                string[] values = line.Split(';');
                if (values.Length > 3)
                {
                    int columnValue;
                    if (int.TryParse(values[3], out columnValue))
                    {
                        teliTalalt += columnValue;
                    }
                }
            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma: {teliTalalt} ");
            Console.ReadKey();
        }
    }
}