using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cbradio
{
    class Sor
    {
        public int Ora { private get; set; }
        public int Perc { private get; set; }
        public int AdasDb { get; set; }
        public string Nev { private get; set; }

        public int szamalalo()
        {
            return Ora * 60 + Perc;
        }
    }
}
