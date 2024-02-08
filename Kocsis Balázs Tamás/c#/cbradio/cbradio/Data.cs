using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cbradio
{
    internal class Data
    {
        public int Ora {get; private set;}
        public int Perc { get; private set;}
        public int Kezdes { get; private set; }
        public int Adatdb { get; private set;}
        public string Nev { get; private set;}

        public Data(string sor)
        {
            string[] m = sor.Split(';');
            Ora = int.Parse(m[0]);
            Perc = int.Parse(m[1]);
            Adatdb = int.Parse(m[2]);
            Nev = (m[3]);
        }

        public int AtszamolPercre()
        {
            return Ora * 60 + Perc;
        }

        


    }
}
