using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00P1
{
    internal class Ember
    {
        public Ember(string n, int é, int sz)
        {
            Név = n;
            Életkor = é;
            Irányítószám = sz;
        }
        private string név;
        public string Név
        {
            get
            {
                return név;
            }
            set
            {
                if (value.Length != 0) név = value;
                else Exception("A név mező nem lehet üres!");
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
                if (value >= 0) életkor = 0;
                else Exception("Az életkor nem lehet negatív! ");
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
                else Exception("Az irányítószám négy karakter! ");
            }
        }
        private void Exception(string s)
        {
            throw new Exception(s);
        }
    }
}
