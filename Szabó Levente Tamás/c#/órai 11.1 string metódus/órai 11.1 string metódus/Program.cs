using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace órai_11._1_string_metódus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Szoftverfejlesztés";
            string str2 = str.Substring(8, 3);
            string str3 = "Réges rég várva várt engem";
            string str4 = str.Replace("várt", "árt"); 
            int index = str.IndexOf("vár");
            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}
