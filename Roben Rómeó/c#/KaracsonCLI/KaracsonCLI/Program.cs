using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KaracsonCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiBevetel>munkak = new List<NapiBevetel>();
            StreamReader sr = new StreamReader("diszek.txt");
            while (!sr.EndOfStream)  
            {
                munkak.Add(new NapiBevetel(sr.ReadLine()));
            }
            sr.Close();



            Console.WriteLine($"4.Feladat: Összesen {NapiBevetel.KeszultDb} darab dísz készult");

            bool nemKeszultDisz = false;
            foreach (NapiBevetel disz in munkak)
            {
                if (disz.HarangKesz == 0 && disz.AngyalkaKesz==0 && disz.FenyofaKesz==0)   
                {
                    nemKeszultDisz = true;
                    break;

                }

            }
            if (nemKeszultDisz)
            {
                Console.WriteLine("nem készult semmi");
            }

            else
            {
                Console.WriteLine("készult mindennap");
            }

            int nap;
            do
            {
                Console.WriteLine("A keresett nap [1-40]:  ");
                nap = int.Parse(Console.ReadLine());
            }while (nap < 1 || nap> 40);
            int harangok = 0;
            int angyalok = 0;
            int fenyofa = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += munkak[i].HarangKesz + munkak[i].HarangEladott;
                angyalok += munkak[i].AngyalkaKesz + munkak[i].AngyalkaEladott;
                fenyofa += munkak[i].FenyofaKesz + munkak[i].FenyofaEladott;

            }

            Console.WriteLine($"    A(z) {nap}. nap végén {harangok} harang; {angyalok} angyal; {fenyofa} fadísz maradt");

            Console.WriteLine("a legtöbbet eladott disz:  ");
            Dictionary<string,int > eladottak = new Dictionary<string,int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fadisz", 0);
            foreach (NapiBevetel item in munkak) 
            {
                eladottak["harang"] -= item.HarangKesz;
                eladottak["Angyalka"] -= item.AngyalkaEladott;
                eladottak["Fadísz"] -= item.FenyofaEladott;
            }
            int max = eladottak.Values.Max();

            Console.WriteLine($"{max} darab");
            foreach (var item in eladottak)
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }
            Console.WriteLine("peti ");

            StreamWriter sw = new StreamWriter("bevetel.txt");
            int legalabb10000 = 0;
            foreach( NapiBevetel item in munkak) 
            {
                if(item.Napihaszon() >= 10000)
                {
                    sw.WriteLine($"{item.Nap} : {item.Napihaszon()}");
                        legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon legalabb 10000Ft volt a profit");
            sw.Close();


            Console.ReadKey();
        }
    }
}
