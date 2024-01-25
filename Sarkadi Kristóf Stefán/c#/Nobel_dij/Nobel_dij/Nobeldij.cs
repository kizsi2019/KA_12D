using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nobel_dij
{
    internal class Dijazot
    {
        public int Ev { get; private set; }
        public string Nev { get; private set; }
        public string SzuletesHalalozas { get; private set; }
        public string Orszagkod {  get; private set; }

        public Dijazot(string sor)
        {
            string[] m = sor.Split(';');
            Ev = int.Parse(m[0]);
            Nev = m[1];
            SzuletesHalalozas = m[2];
            Orszagkod = m[3];
        }
    }
}
