﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_18_orvosi
{
    internal class Díjazott
    {
        public int Év { get; private set; }
        public string Név {  get; private set; }
        public string SzületésHalálozás { get; private set; }
        public string Országkód {  get; private set; }
        public Díjazott(string sor)
        {
            string[] m = sor.Split(';');
            Év = int.Parse(m[0]);
            Név = m[1];
            SzületésHalálozás = m[2];
            Országkód = m[3];
        }
    }
}
