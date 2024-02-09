using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbradio
{
    internal class Radio
    {
        public int Ora { get; private set; }
        public int Perc { get; private set; }
        public int AdasDb { get; private set; }
        public string Nev { get; private set; }

        public Radio (string sor)
        {
            string[] m = sor.Split(';');
            Ora = int.Parse(m[0]);
            Perc = int.Parse(m[1]);
            AdasDb = int.Parse(m[2]);
            Nev = m[3];
        }
    }
}
