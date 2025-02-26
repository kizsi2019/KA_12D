﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bükk_2019
{
    public class Versenyzok
    {
        public string Rajtszam {  get; private set; }
        public string Kategoria { get; private set; }
        public string Nev { get; private set; }
        public string Egyesulet { get; private set; }
        public TimeSpan Ido {  get; private set; }
        public string Tav { get; private set; }
        public bool NoiVersenyzok
        {
            get
            {
                return Kategoria.Last() == 'n';
            }
        }
        public bool tobbMintHat
        {
            get
            {
                return Ido > new TimeSpan(6, 0, 0);
            }
        }

        public Versenyzok(string sor) 
        {
            string[] m = sor.Split(';');
            Rajtszam = m[0];
            Kategoria = m[1];
            Nev = m[2];
            Egyesulet = m[3];
            int ora = int.Parse(m[4].Split(':')[0]);
            int perc = int.Parse(m[4].Split(':')[1]);
            int masodperc = int.Parse(m[4].Split(':')[2]);
            Ido = new TimeSpan(ora, perc, masodperc);
            Tav = new VersenyTav(Rajtszam).Tav;
        }
    }
}
