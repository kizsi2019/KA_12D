using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tömbök
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] randomoltszamok_Vektor = new int[10];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Vektor.Length; i++)
            {
                //for ciklusssal írni és olvasni is tudunk 
                randomoltszamok_Vektor[i] = r.Next(0, 100);
            }
            foreach (int item in randomoltszamok_Vektor)
            {
                //csak olvasásra jó 
                Console.WriteLine(item);
            }
            Array.Sort(randomoltszamok_Vektor); 
            Console.WriteLine("Rendezve");
            foreach (int item in randomoltszamok_Vektor)
            {
                //csak olvasásra jó 
                Console.WriteLine(item);
            }
            Array.Reverse(randomoltszamok_Vektor);
            Console.WriteLine("Fordítva");
            foreach (int item in randomoltszamok_Vektor)
            {
                //csak olvasásra jó 
                Console.WriteLine(item);
            }*/
            /*int[,] randomoltszamok_Matrix = new int[3,3];
            Random r = new Random();
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    randomoltszamok_Matrix[i, j] = r.Next(0, 100);
                }
                
            }
            foreach (int item in randomoltszamok_Matrix)
            {
                //csak olvasásra jó 
                Console.WriteLine(item);
            }*/
            int[,] randomoltszamok_Matrix = new int[3,3];
            
            for (int i = 0; i < randomoltszamok_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomoltszamok_Matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Add meg a matrix egy elemét!");
                    randomoltszamok_Matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
             
            }
            foreach (int item in randomoltszamok_Matrix)
            {
                //csak olvasásra jó 
                Console.WriteLine(item);
            }
            int összeg = 0;
            foreach (int item in randomoltszamok_Matrix)
            {
                összeg += item;
            }

            int min = randomoltszamok_Matrix[0,0];
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item < min)
                {
                    min = item;

                }
            }
            int max = randomoltszamok_Matrix[0, 0];
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item > max)
                {
                    max = item;

                }
            }
            int szamlalo = 0;
            foreach (int item in randomoltszamok_Matrix)
            {
                if (item == 0)
                {
                    szamlalo++;

                }
            }
            Console.WriteLine("A mátrix összege: " + összeg);
            Console.WriteLine("A mátrix legnagyobb száma: " + max);
            Console.WriteLine("A mátrix legkisebb száma: " + min);
            Console.WriteLine("0 száma: " + szamlalo);
            /*
            Console.WriteLine("Adja meg a karakterláncot: ");
            string str = Console.ReadLine(); 
            //mivel tudjuk, hogy a szamlalo sohasem lesz negatív, ezért állítsuk uint-re a típusát és 0 kezdőértékkel:
            uint szamlalo = 0; 
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') szamlalo++;
            }
            Console.WriteLine("Szóközök száma: " + szamlalo);

            */
            Console.ReadKey();
        }
    }
}
