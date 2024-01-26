using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bukkmarathon2019
{
    internal class versenyző
    {
        public string rajtszam { get; private set; }
        public string kategoria { get; private set; }
        public string nev { get; private set; }
        public string egyesület { get; private set; }
        public string tav { get; private set; }

        public versenyző(string sor)
        {
            string[] m = sor.Split(';');
            rajtszam = m[0];
            kategoria = m[1];
            nev = m[2];
            egyesület = m[3];
            tav = new versenytav(rajtszam).Tav;
            int ora = int.Parse(m[4]).Split(';')[0];
            int perc = int.Parse(m[4]).Split(';')[0];
            int omp = int.Parse(m[4]).Split(';')[0];
            ido = new TimeSpan(ora, perc, omp);
            tav = new versenytav(rajtszam).Tav;
        }
    }
}
