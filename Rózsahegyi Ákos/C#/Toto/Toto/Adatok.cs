using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class Adatok
    {
        public int Ev { get; private set; }
        public int Het { get; private set; }
        public int Fordulo { get; private set; }
        public int T13p1 { get; private set; }
        public int Ny13p1 { get; private set; }
        public string Eredmenyek { get; private set; }

        public Adatok(string sor)
        {
            string[] m = sor.Split(';');
            Ev = int.Parse(m[0]);
            Het = int.Parse(m[1]);
            Fordulo = int.Parse(m[2]);
            T13p1 = int.Parse(m[3]);
            Ny13p1 = int.Parse(m[4]);
            Eredmenyek = m[5];
        }
    }
}
