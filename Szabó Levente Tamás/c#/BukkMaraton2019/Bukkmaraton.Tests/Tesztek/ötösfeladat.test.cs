using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukkmaraton.Tests.Tesztek
{
    public class ötösfeladat
    {
        [Fact]
        public void CountFemaleShortDistanceRunners_ReturnsCorrectCount()
        {
            // Arrange
            var versenyzok = new versenyzo(); // vagy bármi, amivel inicializáljuk a versenyzők listáját
                                               // Itt inicializálhatjuk a szükséges versenyzőket a teszteléshez

            // Act
            int actualCount = versenyzok.FemaleShortDistanceRunners();

            // Assert
            int expectedCount = // Az elvárt női versenyzők száma a rövid távú versenyen
            Assert.Equal(expectedCount, actualCount).WithMessage("A női versenyzők száma a rövid távú versenyen nem megfelelő.");
        }
    }
    public class versenyzo
    {
        public bool NoiVersenyzo { get; set; }
        public string Tav { get; set; }

        internal int FemaleShortDistanceRunners()
        {
            throw new NotImplementedException();
        }
    }
}