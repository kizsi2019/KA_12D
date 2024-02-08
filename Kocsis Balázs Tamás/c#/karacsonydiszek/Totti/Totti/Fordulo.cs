using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totti
{
    internal class Fordulo
    {
        public int Év { get; private set; }
        public int Hét { get; private set; }
        public int Forduló { get; private set; }
        public double Telidb { get; private set; }
        public double TeliNyer { get; private set; }
        public string Eredmények { get; private set; }

        public Fordulo(string sor) 
        {
            string[] m = sor.Split(';');
            Év = int.Parse(m[0]);
            Hét = int.Parse(m[1]);
            Forduló = int.Parse(m[2]);
            Telidb = double.Parse(m[3]);
            TeliNyer = double.Parse(m[4]);
            Eredmények = m[5];
        }

        public override string ToString()
        {
            string output = "";
            output += "\tÉv: ";
            output += Év;
            output += "\n\tHét: ";
            output += Hét;
            output += "\n\tForduló: ";
            output += Forduló;
            output += "\n\t:Telitalálat: ";
            output += Telidb;
            output += "\n\tNyeremény: ";
            output += TeliNyer;
            output += "\n\tEredmények: ";
            output += Eredmények;
            return output;
        }

    }
}
