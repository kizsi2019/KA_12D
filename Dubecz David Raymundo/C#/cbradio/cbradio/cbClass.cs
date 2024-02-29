using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbradio
{
    internal class cbClass
    {
        public int ora { get; private set; }
        public int perc { get; private set; }
        public int adasDb { get; private set; }
        public String nev { get; private set; }

        public cbClass(string sor)
        {
            string[] d = sor.Split(';');
            ora = Convert.ToInt32(d[0]);
            perc = Convert.ToInt32(d[1]);
            adasDb = Convert.ToInt32(d[2]);
            nev = d[3];
        }

        public int atSzamolPercre()
        {
            return ora * 60 + perc;
        }
    }
}
