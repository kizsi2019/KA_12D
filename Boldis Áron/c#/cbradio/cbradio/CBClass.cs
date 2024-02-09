
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdc_cbRadio
{
    class CBClass
    {
        
        private int ora;
        private int perc;
        private int adasDb;
        private String nev;

        
        public CBClass(string sor)
        {
            string[] d = sor.Split(';');
            ora = Convert.ToInt32(d[0]);
            perc = Convert.ToInt32(d[1]);
            adasDb = Convert.ToInt32(d[2]);
            nev = d[3];
        }

        public int Ora { get => ora; set => ora = value; }
        public int Perc { get => perc; set => perc = value; }
        public int AdasDb { get => adasDb; set => adasDb = value; }
        public string Nev { get => nev; set => nev = value; }

        public int atSzamolPercre()
        {
            return ora * 60 + perc;
        }

    }
}