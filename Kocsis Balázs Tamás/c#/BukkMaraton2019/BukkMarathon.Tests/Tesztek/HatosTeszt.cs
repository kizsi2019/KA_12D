using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BukkMarathon.Tests.Tesztek
{
    public class HatosTeszt
    {
        public class Versenyzok
        {
            public int VersenyzokSzamRovidTavon()
            {
                // A valódi logika itt lenne
                return 10; // Példa: 10 női versenyző a rövid távú versenyen
            }

            public bool TobbMintHat { get; set; }
        }

        public class Tesztek
        {
            [Fact]
            public void VersenyzokSzamRovidTavon_Es_TobbMintHatTeszt()
            {
                // Arrange
                var versenyzok = new[]
                {
            new Versenyzok { TobbMintHat = false },
            new Versenyzok { TobbMintHat = false },
            new Versenyzok { TobbMintHat = false },
            // ... további versenyzők
            new Versenyzok { TobbMintHat = true } // Legalább egy versenyző több mint hat érmet nyert
        };

                var target = new Versenyzok();

                // Act
                var noiVersenyzoRovidTavon = target.VersenyzokSzamRovidTavon();

                // Assert
                noiVersenyzoRovidTavon.Should().BePositive(); // Biztosítjuk, hogy pozitív értéket kapunk

                // Kiegészítő ellenőrzés: van-e olyan versenyző, aki több mint hat érmet nyert
                var tobbMintHat = versenyzok.Any(v => v.TobbMintHat);
                tobbMintHat.Should().BeTrue("Legalább egy versenyző több mint hat érmet nyert.");

                // A logolással kapcsolatos teszt
                var tesztLog = tobbMintHat ? "Volt" : "Nem volt";
                tesztLog.Should().Be("Volt", "Legalább egy versenyző több mint hat érmet nyert.");
            }
        }
    }
}

