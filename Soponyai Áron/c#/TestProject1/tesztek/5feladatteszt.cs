using Xunit;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton.Tests.Tesztek
{
    public class Versenyzo
    {
        public bool NoiVersenyzo { get; set; }
        public string Tav { get; set; }
        public int Ido { get; set; }
        public int Rajtszam { get; set; }
        public bool TobbMintHat { get; set; }
    }

    public class feladatteszt5
    {
        [Fact]
        public void NoiVersenyzoRovidTavon_SzamolasHelyes()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Hosszú" },
            new Versenyzo { NoiVersenyzo = false, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" }
        };
            int elvartNoiVersenyzoRovidTavon = 2;

            // Act
            int noiVersenyzoRovidTavon = 0;
            foreach (var item in versenyzok)
            {
                if (item.NoiVersenyzo && item.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
            }

            // Assert
            noiVersenyzoRovidTavon.Should().Be(elvartNoiVersenyzoRovidTavon, because: "a női versenyzők száma rövid távú versenyen számolásának helyesnek kell lennie");
        }
    }
}
