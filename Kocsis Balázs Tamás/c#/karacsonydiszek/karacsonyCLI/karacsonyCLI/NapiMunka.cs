using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyCLI
{
    class NapiMunka
    {
        public static int KeszDb { get; private set; }
        public int Nap { get; private set; }
        public int KeszH { get; private set; }
        public int EladottH { get; private set; }
        public int KeszA { get; private set; }
        public int EladottA { get; private set; }
        public int KeszF { get; private set; }
        public int EladottF { get; private set; }

        public NapiMunka(string sor)
        {
            string[] s = sor.Split(';');
            Nap = Convert.ToInt32(s[0]);
            KeszH = Convert.ToInt32(s[1]);
            EladottH = Convert.ToInt32(s[2]);
            KeszA = Convert.ToInt32(s[3]);
            EladottA = Convert.ToInt32(s[4]);
            KeszF = Convert.ToInt32(s[5]);
            EladottF = Convert.ToInt32(s[6]);

            NapiMunka.KeszDb += KeszA + KeszF + KeszH;
        }

        public int NapiBevetel()
        {
            return -(EladottH * 1000 + EladottA * 1350 + EladottF * 1500);
        }
    }
}
