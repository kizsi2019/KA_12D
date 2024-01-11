using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace valamilyen_utak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("utak.txt");
            List<double> utak = new List<double>();
            while (!sr.EndOfStream)
            {
                utak.Add(double.Parse(sr.ReadLine()));

            }
            sr.Close();
            double összesút = 0;
            for (int i = 0; i < utak.Count; i++)
            {
                összesút += utak[i];

            }
            Console.WriteLine("Az autó ennyit ment:  ", összesút);
        }
    }
}
