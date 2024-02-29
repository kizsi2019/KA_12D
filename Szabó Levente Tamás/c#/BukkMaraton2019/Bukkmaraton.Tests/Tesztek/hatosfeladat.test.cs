using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukkmaraton.Tests.Tesztek
{
    public class hatosfeladat
    {
        [Fact]
        public void CheckIfAnyHasMoreThanSix_ReturnsCorrectResult()
        {
            // Arrange
            var versenyzok = new versenyzo(); // vagy bármi, amivel inicializáljuk a versenyzők listáját
                                               // Itt inicializálhatjuk a szükséges versenyzőket a teszteléshez

            // Act
            bool tobbMintHat = false;
            foreach (var v in versenyzok)
            {
                if (v.TobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }

            // Assert
            Assert.True(tobbMintHat, "Nem volt olyan versenyző, aki több mint hat távot futott."); // Az elvárt érték True, ha van olyan versenyző, aki több mint hat távot futott
        }
    }
    public class versenyzo
    {
        public string versenyzok { get; set; }
    }
}
