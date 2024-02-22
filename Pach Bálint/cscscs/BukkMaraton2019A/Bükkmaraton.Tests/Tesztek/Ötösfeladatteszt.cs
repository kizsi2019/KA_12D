using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bükkmaraton.Tests.Tesztek.Hatosfeladatteszt;

namespace Bükkmaraton.Tests.Tesztek
{
    public class Ötösfeladatteszt
    {
        [Fact]
        public void NoiVersenyzoRovidTavon_SzamolasHelyes()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = false, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Hosszú" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" }
        };

            // Act
            int noiVersenyzoRovidTavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavon++;
                }
            }

            // Assert
            noiVersenyzoRovidTavon.Should().Be(2, because: "két női versenyző versenyzett a rövid távon");


        }
        public class Versenyzo
        {
            public bool NoiVersenyzo { get; set; }
            public string Tav { get; set; }
        }
    }
}
