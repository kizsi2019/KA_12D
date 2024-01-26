using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton2019
{
    public class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Kategoria { get; private set; }
        public string Nev { get; private set; }
        public string Egyesulet { get; private set; }
        public TimeSpan Ido { get; private set; }
        public string Tav { get; private set; }
        public bool NoiVersenyzo
        {
            get
            {
                return Kategoria.Last() == 'n';
            }
        }
        public bool TobbMintHat
        {
            get
            {
                return Ido > new TimeSpan(6, 0, 0); 
            }
        }
        public Versenyzo(string sor)
        {
            string[] matrix = sor.Split(';');
            Rajtszam = matrix[0];
            Kategoria = matrix[1];
            Nev = matrix[2];
            Egyesulet = matrix[3];
            int ora = int.Parse(matrix[4].Split(':')[0]);
            int perc = int.Parse(matrix[4].Split(':')[1]);
            int masodperc = int.Parse(matrix[4].Split(':')[2]);
            Ido = new TimeSpan(ora, perc, masodperc);
            Tav = new Versenytav(Rajtszam).Tav;
        }
    }
}
