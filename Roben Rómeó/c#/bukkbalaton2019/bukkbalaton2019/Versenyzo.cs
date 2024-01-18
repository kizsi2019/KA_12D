using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bukkbalaton2019
{
    internal class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Kategoria { get; private set; }
        public string Nev { get; private set; }
        public string Egyesulet { get; private set; }
        public TimeSpan Ido { get; }
        public string Tav { get; private set; }
        public Versenyzo(string sor, TimeSpan ido)
        {
            string[] m = sor.Split(';');
            Rajtszam = m[0];
            Kategoria = m[1];
            Nev = m[2];
            Egyesulet = m[3];
            int ora = int.Parse(m[4].Split(';')[0]);
            int perc = int.Parse(m[4].Split(';')[1]);
            int omp = int.Parse(m[4].Split(';')[2]);
            Ido = new TimeSpan(ora, perc, omp);
            Tav = new VersenyTav(Rajtszam).Tav;
            Ido = ido;
        }
    }
}