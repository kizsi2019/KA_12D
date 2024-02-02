using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

class Fordulo
{
    public int Ev { get; set; }
    public int Het { get; set; }
    public int ForduloSzam { get; set; }
    public int T13p1 { get; set; }
    public long Ny13p1 { get; set; } // Nagy nyeremények kezelésére long típust használunk
    public string Eredmenyek { get; set; }

    public Fordulo(string sor)
    {
        var adatok = sor.Split(';');
        Ev = int.Parse(adatok[0]);
        Het = int.Parse(adatok[1]);
        ForduloSzam = int.Parse(adatok[2]);
        T13p1 = int.Parse(adatok[3]);
        Ny13p1 = long.Parse(adatok[4]);
        Eredmenyek = adatok[5];
    }
}