using Xunit;
using FluentAssertions;
using System.Linq;
using System.Collections.Generic;

namespace Bukkmarathon.Test
{
    public class UnitTest1
    {
        [Fact]
        public void NoiVersenyzoRovidTavon_CountsCorrectly()
        {
            // Arrange
            var versenyzok = new[]
            {
            new Versenyzo { NoiVersenyzo = true, Tav = "R�vid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "R�vid" },
            new Versenyzo { NoiVersenyzo = false, Tav = "R�vid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Hossz�" },
            new Versenyzo { NoiVersenyzo = true, Tav = "R�vid" }, // New data
            new Versenyzo { NoiVersenyzo = true, Tav = "R�vid" }  // New data
        };
            int expectedCount = 4; // Updated expected count

            // Act
            int actualCount = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "R�vid")
                {
                    actualCount++;
                }
            }

            // Assert
            actualCount.Should().Be(expectedCount);
        }
    }
    [Fact]
    public void TobbMintHat_ExistsInVersenyzok_ReturnsCorrectResult()
    {
        // Arrange
        var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = true },
            new Versenyzo { TobbMintHat = false }
        };

        // Act
        bool result = versenyzok.Any(v => v.TobbMintHat);

        // Assert
        result.Should().BeTrue();
    }
}

public class Versenyzo
    {
    public bool TobbMintHat { get; set; }   
    public bool NoiVersenyzo { get; set; }
        public string Tav { get; set; }
    }
}