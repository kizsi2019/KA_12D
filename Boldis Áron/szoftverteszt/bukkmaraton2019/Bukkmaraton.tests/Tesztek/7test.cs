using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bukkmaraton.tests.Tesztek.ÖtösfeladatTeszt;

namespace Bukkmaraton.tests.Tesztek
{
    public class _7tes
    {
        [Fact]
        public void MegadottVersenyzokkel_MegfelelőGyőztesFFRovidTávon()
        {
            // Beállítunk néhány versenyzőt
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Rajtszam = 1, Nev = "Kiss János", Egyesulet = "FTC", Ido = 12.5 },
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Rajtszam = 2, Nev="Nagy Béla", Egyesulet = "UTE", Ido = 12.3 },
            new Versenyzo { Tav = "Hosszú", Kategoria = "ff", Rajtszam = 3, Nev="Szabó István", Egyesulet = "Bp. Honvéd", Ido = 25.1 },
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Rajtszam = 4, Nev="Horváth László", Egyesulet = "Vasas", Ido = 12.7 },
        };

            // Futtatjuk a kódot
            var gyoztesFerfiRovidTav = GetGyoztesFerfiRovidTav(versenyzok);

            // Ellenőrizzük az eredményt
            gyoztesFerfiRovidTav.Should().NotBeNull();
            gyoztesFerfiRovidTav.Rajtszam.Should().Be(2);
            gyoztesFerfiRovidTav.Nev.Should().Be("Nagy Béla");
            gyoztesFerfiRovidTav.Egyesulet.Should().Be("UTE");
            gyoztesFerfiRovidTav.Ido.Should().Be(12.3);
        }

        private Versenyzo GetGyoztesFerfiRovidTav(List<Versenyzo> versenyzok)
        {
            versenyzo gyoztesFerfiRovidTav = null;
            foreach (var v in versenyzok)
            {
                if (v.Tav == "Rövid" && v.Kategoria == "ff")
                {
                    if (gyoztesFerfiRovidTav == null)
                    {
                        gyoztesFerfiRovidTav = v;
                    }
                    else
                    {
                        if (v.Ido < gyoztesFerfiRovidTav.Ido)
                        {
                            gyoztesFerfiRovidTav = v;
                        }
                    }
                }
            }
            return gyoztesFerfiRovidTav;
        }
    }
}

public class VersenyzoC 
{
    public string Tav { get; set; }
    public string Kategoria { get; set; }
    public int Rajtszam { get; set; }
    public string Nev { get; set; }
    public string Egyesulet { get; set; }
    public double Ido { get; set; }
}
