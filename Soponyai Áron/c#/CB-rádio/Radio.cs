using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB_rádio
{
    internal class Radio
    {
        public int Ora { get; private set; }
        public int Perc { get; private set; }
        public int AdasDB { get; private set; }
        public string Nev { get; private set; }

        public Radio(string sor)
        {
            string[] n = sor.Split(';') ;
            Ora = int.Parse(n[0]);
            Perc = int.Parse(n[1]);
            AdasDB = int.Parse(n[2]);
            Nev = n[3];
        }

        public int AtszamolPercre()
        {
            return Ora * 60 + Perc;
        }
    }
}
