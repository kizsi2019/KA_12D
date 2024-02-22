using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace delegacio
{
    internal class Program
    {
        /*delegate void VoidDelegate();
        static void Metodus()
        {
            Console.WriteLine("A metodus lefutott!");
        }
        static void Main(string[] args)
        {
            VoidDelegate vd = new VoidDelegate(Metodus);
            vd();
            Console.ReadKey();  
        }

        delegate void Beléptetés(string str);
        static void Üdvözlés(string név)
        {
            Console.WriteLine("Üdvözzöllek {0}!", név);
        }
        static void Üzenet(string név)
        {
            Console.WriteLine("Kedves {0}, köszönjük a belépésedet a rendszerbe...", név);
        }
        static void Main(string[] args)
        {
            Beléptetés b = new Beléptetés(Üdvözlés) + new Beléptetés(Üzenet);
            Console.Write("Add meg a nevedet: ");
            string név = Console.ReadLine();
            b(név);
        }
        */

        class Esemény : EventArgs
        {
            public string üzenet;
            //aki nem tudja, mit csinál a konstruktor lapozzon vissza!
            public Esemény(string str) : base()
            {
                üzenet = str;
            }
        }

        class Szám
        {
            public delegate void EseménykezelőDelegate(object o, Esemény e);
            public event EseménykezelőDelegate ÁllapotváltozásEsemény;
            int szam = 0;
            public int Szam
            {
                get { return szam; }
                set
                {
                    szam = value;
                    ÁllapotVáltozás();
                }
            }
            private void ÁllapotVáltozás()
            {
                if (ÁllapotváltozásEsemény != null)
                    ÁllapotváltozásEsemény(this, new Esemény("A szám megváltozott!"));
                //a this-szel átadja az osztály saját magát
            }
        }
        class Programm
        {
            static void EseményKezelés(object eseménytkiváltóosztály, Esemény e)
            {
                Console.WriteLine(e.üzenet);
            }
            static void Main(string[] args)
            {
                Szám sz = new Szám();
                sz.ÁllapotváltozásEsemény += EseményKezelés; //feliratkozunk az eseményre
                sz.Szam = 21; //kiváltjuk az eseményt;
                Console.ReadKey();
            }
        }

    }
}
