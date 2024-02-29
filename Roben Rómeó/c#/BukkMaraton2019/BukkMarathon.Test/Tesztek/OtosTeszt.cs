using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMarathon.Test.Tesztek
{
    public class OtosTeszt
    {
        [Fact]
        public void Női_Versenyzők_Száma_Rövid_Távú_Versenyen_Should_Return_Correct_Count()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Hosszú" },
            new Versenyzo { NoiVersenyzo = false, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = false, Tav = "Hosszú" }
        };

            int expectedCount = 2; // Expected number of female competitors in short distance races

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
            noiVersenyzoRovidTavon.Should().Be(expectedCount);
        }
    }

    public class Versenyzo
    {
        public bool NoiVersenyzo { get; set; }
        public string Tav { get; set; }
    }
}

