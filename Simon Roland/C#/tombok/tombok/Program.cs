using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] randomoltszamok_Vektor = new int[10];

             Random r = new Random();

             for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
             {
                 randomoltszamok_Vektor[i] = r.Next(0,100);
             }

             foreach(int item in randomoltszamok_Vektor)
             {
                 Console.WriteLine(item);    
             }
             Array.Sort(randomoltszamok_Vektor);
             Console.WriteLine("rendezve");


             foreach (int rendezett in randomoltszamok_Vektor)
             {
                 Console.WriteLine(rendezett);
             }

             Array.Reverse(randomoltszamok_Vektor);
             Console.WriteLine("Forditva");


             foreach (int forditott in randomoltszamok_Vektor)
             {
                 Console.WriteLine(forditott);
             }
            
            int[,] randomoltszamok_Matrix = new int[3, 3];

            Random r = new Random();
            for(int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    randomoltszamok_Matrix[i, j] = r.Next(0, 100);
                }
            }
            foreach(int item in randomoltszamok_Matrix)
            {
                Console.WriteLine(item);
            }

            
            
            int[,] szamok_Matrix = new int[3, 3];

            for (int i = 0; i < szamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < szamok_Matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a mátrix elemeit! ");
                    
                    szamok_Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            foreach (int item in szamok_Matrix)
            {
                Console.WriteLine(item);
                
            }
            int osszeg = 0;
            foreach (int item in szamok_Matrix)
            {
                osszeg = osszeg + item;
            }
            Console.WriteLine("A mátrix összege: "+ osszeg);

            int max = 0;
            int min = 120;
            
            foreach(int item in szamok_Matrix)
            {
                if (item > max )
                {
                    max = item;
                }
            }
            foreach(int item in szamok_Matrix)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("A legnagyobb: "+ max);
            Console.WriteLine("A legkisebb: "+min);

            Console.WriteLine("Adja meg a karakterláncot: ");
            string str = Console.ReadLine();
            uint szamlalo = 0;
            for (int i = 0; i <str.Length; i++)
            {
                if (str[i] == ' ') szamlalo++;
            }
            Console.WriteLine("Szóközök száma: " + szamlalo);

            string str = "Szoftverfejlesztés";
            string str2 = str.Substring(8, 3);

         

            string str = "Réges rég várva várt engem";
            int i = str.IndexOf("alma");
            Console.WriteLine(str);
            Console.WriteLine(i);
*/
            string str = "Réges rég várva várt";
            string str2 = str.Replace("vár", "árt");

            string s = "kisbetű";
            string s2 = s.ToUpper();

            string st = "C# programozás könyv";
            string[] stT = st.Split(' ');
            foreach (string i in stT)
            {
                Console.WriteLine(i);
            }
            string k = "kisbetű";
            string k1 = k.Remove(3, 3);
            Console.WriteLine(k1);










            Console.ReadKey();
        }
    }
}
