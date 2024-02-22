using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_19._1_delegate_2
{
    internal class Program
    {
        delegate void Beléptetés(string str);
        static void Üdvözlés(string név)
        {
            Console.WriteLine("Üdvözöllek {0}!", név);
        }
        static void Üzenet(string név)
        {
            Console.WriteLine("Kedves {0} köszönjük a belépést", név);
        }
        static void Main(string[] args)
        {
            Beléptetés b = new Beléptetés(Üdvözlés) + new Beléptetés(Üdvözlés);
            Console.WriteLine("Add meg a neved: ");
            string név = Console.ReadLine();
            b(név);
            Console.ReadKey();
        }
    }
}
