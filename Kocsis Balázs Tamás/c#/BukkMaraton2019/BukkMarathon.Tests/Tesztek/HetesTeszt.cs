using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace BukkMarathon.Tests.Tesztek
{
    public class HetesTeszt
    {
        public class Versenyzo
        {
            public string Tav { get; set; }
            public string Kategoria { get; set; }
            public int Ido { get; set; }
            public int Rajtszam { get; set; }
            public string Nev { get; set; }
            public string Egyesulet { get; set; }
        }

        public class Tesztek
        {
            [Fact]
            public void GyoztesFerfiRovidTavTeszt()
            {
                // Arrange
                var versenyzok = new[]
                {
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Ido = 100, Rajtszam = 1, Nev = "Versenyzo1", Egyesulet = "Egyesulet1" },
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Ido = 90, Rajtszam = 2, Nev = "Versenyzo2", Egyesulet = "Egyesulet2" },
            new Versenyzo { Tav = "Hosszú", Kategoria = "ff", Ido = 110, Rajtszam = 3, Nev = "Versenyzo3", Egyesulet = "Egyesulet3" },
            // ... további versenyzők
        };

                // Act
                var gyoztesFerfiRovidTav = GetGyoztesFerfiRovidTav(versenyzok);

                // Assert
                gyoztesFerfiRovidTav.Should().NotBeNull("Van győztes felnőtt férfi a rövid távú versenyen.");
                gyoztesFerfiRovidTav.Tav.Should().Be("Rövid");
                gyoztesFerfiRovidTav.Kategoria.Should().Be("ff");
                gyoztesFerfiRovidTav.Rajtszam.Should().Be(2, "A 2. rajtszámú versenyző győzött.");
                gyoztesFerfiRovidTav.Nev.Should().Be("Versenyzo2");
                gyoztesFerfiRovidTav.Egyesulet.Should().Be("Egyesulet2");
                gyoztesFerfiRovidTav.Ido.Should().Be(90, "Az idő 90.");
            }

            private Versenyzo GetGyoztesFerfiRovidTav(Versenyzo[] versenyzok)
            {
                Versenyzo gyoztesFerfiRovidTav = null;

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
}
