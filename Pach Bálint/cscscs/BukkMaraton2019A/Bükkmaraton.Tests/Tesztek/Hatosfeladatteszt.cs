using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bükkmaraton.Tests.Tesztek
{
    internal class Hatosfeladatteszt
    {
       

public class VersenyzoTests
    {
        [Fact]
        public void TobbMintHat_WhenAnyVersenyzoTobbMintHat_ShouldBeTrue()
        {
            // Arrange
            var versenyzok = new[]
            {
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = true },
            new Versenyzo { TobbMintHat = false }
        };

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
            tobbMintHat.Should().BeTrue();
        }

        [Fact]
        public void TobbMintHat_WhenNoVersenyzoTobbMintHat_ShouldBeFalse()
        {
            // Arrange
            var versenyzok = new[]
            {
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = false }
        };

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
            tobbMintHat.Should().BeFalse();
        }
    }

    public class Versenyzo
    {
        public bool TobbMintHat { get; set; }
    }

}
}
