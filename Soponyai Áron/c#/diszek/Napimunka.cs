using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace napimunka
{
    internal class Napimunka
    {
        public static int KeszultDb { get; private set; }
        public int Nap { get; private set; }
        public int KészHarangok { get; private set; }
        public int EladottHarangok { get; private set; }
        public int KészAngyalok { get; private set; }
        public int EladottAngyalok { get; private set; }
        public int KészFák { get; private set; }
        public int EladottFák { get; private set; }

        public Napimunka(string sor)
        {
            string[] s = sor.Split(';');
            Nap = Convert.ToInt32(s[0]);
            KészHarangok = Convert.ToInt32(s[1]);
            EladottHarangok = Convert.ToInt32(s[2]);
            KészAngyalok = Convert.ToInt32(s[3]);
            EladottAngyalok = Convert.ToInt32(s[4]);
            KészFák = Convert.ToInt32(s[5]);
            EladottFák = Convert.ToInt32(s[6]);

            Napimunka.KeszultDb += KészHarangok + KészAngyalok + KészFák;
        }

        public int NapiBevetel()
        {
            return -(EladottHarangok * 1000 + EladottAngyalok * 1350 + EladottFák * 1500);
        }
    }
}
