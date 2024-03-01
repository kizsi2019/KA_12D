using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukkmaraton.tests.Tesztek
{
    public class ÖtösfeladatTeszt
    {

        [Fact]
        public void NoiVersenyzoRovidTavonSzamaMegfelelo()
        {
            // Adatok
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { Nev = "Kiss János", NoiVersenyzo = false, Tav = "Rövid" },
            new Versenyzo { Nev = "Nagy Anna", NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo { Nev = "Szabó Péter", NoiVersenyzo = false, Tav = "Hosszú" },
            new Versenyzo { Nev = "Tóth Katalin", NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo { Nev = "Varga Béla", NoiVersenyzo = false, Tav = "Rövid" },
        };

            // Elvárt érték
            var elvartNoiVersenyzoRovidTavon = 2;

            // Teszt
            var noiVersenyzoRovidTavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
            }

            noiVersenyzoRovidTavon.Should().Be(elvartNoiVersenyzoRovidTavon);

        }

        public class Versenyzo
        {
            public string Nev { get; set; }
            public string Tav { get; set; }
            public bool NoiVersenyzo { get; set; }
        }
    }
}

