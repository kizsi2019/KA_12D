using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sudokuCLI
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }

        static List<Feladvany> lista = new List<Feladvany>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Feladvanyok.txt");
            string sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                lista.Add(new Feladvany(sor));

            }
            sr.Close();

            Console.WriteLine("Feladványok száma: " + lista.Count);

            int meret;
            do
            {
                Console.WriteLine("Add meg a feladvány méretét");
                meret = Convert.ToInt32(Console.ReadLine());
            }
            while (meret < 4 || meret > 9);
            int meretdb = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Meret == meret)
                {
                    meretdb++;
                }
            }
            Console.WriteLine("A megadott méretből ennyi van: " + meretdb);
            Console.WriteLine(" {0}x{0} méretű feladványból {1} darab van tárolva ", meret, meretdb);

            Random r = new Random();
            int kivalaszto = 0;
            do 
            {
                kivalaszto = r.Next(0, lista.Count);
            } while (lista[kivalaszto].Meret != meret);
            Console.WriteLine("A kisorolt feladvány kezdő állapota: " + lista[kivalaszto].Kezdo);

            int nemnulladb = 0;
            int hossza = lista[kivalaszto].Kezdo.Length;
            for (int i = 0; i < hossza; i++)
            {
                if (lista[kivalaszto].Kezdo[i] != '0') 
                {
                    nemnulladb++;
                }
            }
            double kitoltottseg = (double)nemnulladb / hossza * 100;
            Console.WriteLine("A kiválasztott feladvány kitöltöttsége: " + kitoltottseg + "%");
            Console.WriteLine("A kiválasztott feladvány kirajzolva: ");
            lista[kivalaszto].Kirajzol();

            string fajlneve = "sudoku" + meret + ".txt";
            StreamWriter sw = new StreamWriter(fajlneve);
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Meret == meret)
                {
                    sw.WriteLine(lista[i].Kezdo);
                }
            }
            sw.Close();
            Console.WriteLine("A kiválasztott méretűek kiírva a fájlba!");
            Console.WriteLine("A " + fajlneve + "állomány létrehozva annyi sorral " + meretdb);

            Console.ReadKey();
        }   
    }
}
