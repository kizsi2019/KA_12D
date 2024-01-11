using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public class Ember
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
                if (value.Length !=0)
                {
                    név = value;
                }
                else Exception("A név nem lehet üres!");
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
                if (value >= 0)
                {
                    életkor = value;
                }
                else Exception("Az életkot nem lejet negatív!");
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
                else Exception("Az irányítószám 4 karakter!");
            }
        }
        private void Exception(string s)
        {
            throw new Exception(s);
        }
    }
}
