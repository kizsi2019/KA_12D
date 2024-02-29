using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMarathon.Tests.Tesztek
{
    public class OtosTeszt
    {
        public class Versenyzo
        {
            public bool NoiVersenyzo { get; set; }
            public string Tav { get; set; }
        }

        public class Tesztek
        {
            [Fact]
            public void NoiVersenyzoRovidTavonTeszt()
            {
                // Arrange
                var versenyzok = new[]
                {
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Hosszú" },
            new Versenyzo { NoiVersenyzo = false, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" },
            // ... további versenyzők
        };

                // Act
                var noiVersenyzoRovidTavon = GetNoiVersenyzoRovidTavon(versenyzok);

                // Assert
                noiVersenyzoRovidTavon.Should().Be(2, "Két női versenyző van a rövid távú versenyen.");
            }

            private int GetNoiVersenyzoRovidTavon(Versenyzo[] versenyzok)
            {
                int noiVersenyzoRovidTavon = 0;

                foreach (var v in versenyzok)
                {
                    if (v.NoiVersenyzo && v.Tav == "Rövid")
                    {
                        noiVersenyzoRovidTavon++;
                    }
                }

                return noiVersenyzoRovidTavon;
            }
        }
    }
}
