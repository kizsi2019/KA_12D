using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toto
{
    internal class Fordulo
    {
        public int Ev { get; set; }
        public int Het { get; set; }
        public int ForduloSzam { get; set; }
        public double TelitalalatNyeremeny { get; set; }
        public double TelitalalatDb { get; set; }
        public string Eredmeny { get; set; }

        public Fordulo(string line)
        {
            string[] splitted = line.Split(';');
            Ev = int.Parse(splitted[0]);
            Het = int.Parse(splitted[1]);
            ForduloSzam = int.Parse(splitted[2]);
            TelitalalatNyeremeny = double.Parse(splitted[3]);
            TelitalalatDb = double.Parse(splitted[4]);
            Eredmeny = splitted[5];
        }
        public override string ToString()
        {
            string output = "";
            output += "\tÉv: ";
            output += Ev;
            output += "\n\tHét: ";
            output += Het;
            output += ".\n\tForduló: ";
            output += ForduloSzam;
            output += ".\n\tTelitalálat: ";
            output += TelitalalatNyeremeny;
            output += " db\n\tNyeremény: ";
            output += TelitalalatDb;
            output += " Ft\n\tEredmények: ";
            output += Eredmeny;
            return output;
        }
    }
}