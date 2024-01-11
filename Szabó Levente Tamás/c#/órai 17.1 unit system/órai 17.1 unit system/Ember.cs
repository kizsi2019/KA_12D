using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_17._1_unit_system
{
    internal class Ember
    {
        public Ember(string n, int é, int isz)
        {
            Név = n;
            Életkor = é;
            Irányítószám = isz;
        }
        private string név;
        public string név
        {
            get
            {
                return név;
            }
            set
            {
                if (value.Length != 0) név = value;
                else Exception("A név mező nem lehet üres");
            }
        }
        private int életkor;
        public int Életkor
        {
            get
            {
                return életkor;
            }
            set
            {
                if (value >= 0) életkor = value;
                else Exception("Az életkor nem lehet negatív!");
            }
        }
        private int irányítószám;
        public int Irányítószám
        {
            get
            {
                return irányítószám;
            }
            set
            {
                if (value.ToString().Length == 4)
                {
                    irányítószám = value;
                }
                else Exception("Az irányítószámnak négy karaktert kell tartalmaznia!");
            }
        }
        private void Exeption(string s)
        {
            throw new Exception(s);
        }
    }
}
