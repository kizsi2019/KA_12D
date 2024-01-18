using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using bukkbalaton2019;

namespace BukkMarathon2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"versenyt nem teljesítők:   {(1 - versenyzok.Count / 681.0) * 100} %");
            int noiVersenyzoRovidTavon = 0;
            foreach (var v in versenyzok) 
            {
                if(v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
                
            }
            Console.WriteLine($"női versenyzok száma a versenyen:  {noiVersenyzoRovidTavon}fo%" );
            bool tobbMintHat = false;
            foreach(var v in versenyzok)
            {
                if(v.TobbMnitHat)
                {
                    tobbMintHat |= true;
                    break;
                }
            }
            Console.WriteLine($"volt aki 6 oraig volt pályan?:  {(tobbMintHat? "volt": "nem volt")} ilyen versenyzo");
            Console.ReadKey();
        }
    }
}
