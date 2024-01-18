using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bukkbalaton2019
{
    class VersenyTav
    {
        private String rajtSzam;

        public String getTav()
        {
            switch (rajtSzam[0])
            {
                case 'M':
                    return "Mini";
                case 'R':
                    return "Rövid";
                case 'K':
                    return "Közép";
                case 'H':
                    return "Hosszú";
                case 'E':
                    return "Pedelec";
                default:
                    return "Hibás rajtszám";
            }
        }

        public VersenyTav(String rajtszam)
        {
            rajtSzam = rajtszam;
        }
    }
}
