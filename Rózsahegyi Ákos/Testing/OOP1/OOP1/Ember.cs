using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Ember
    {
        public Ember(string n, int e, int sz)
        {
            Nev = n;
            Eletkor = e;
            Iranyitoszam = sz;
        }
        private string nev;
        public string Nev
        {
            get
            {
                return nev; 
            }
            set
            {
                if (value.Length != 0)
                {
                    nev = value;
                }
                else
                {
                    Exception("A név mező nem lehet üres!");
                }
            }
        }

        private int eletkor;
        public int Eletkor
        {
            get
            {
                return eletkor;
            }
            set
            {
                if (value >= 0)
                {
                    eletkor = value;
                }
                else
                {
                    Exception("Az életkor nem lehet negatív!");
                }
            }
        }

        private int iranyitoszam;
        public int Iranyitoszam
        {
            get
            {
                return iranyitoszam;
            }
            set
            {
                if (value.ToString().Length == 4)
                {
                    iranyitoszam = value;
                }
                else
                {
                    Exception("Az irányítószám négy karakter!");
                }
            }
        }
        private void Exception(string s)
        {
            throw new Exception(s);
        }
    }
}
