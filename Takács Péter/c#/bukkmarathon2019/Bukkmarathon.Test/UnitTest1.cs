using FluentAssertions;

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
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = false, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Hosszú" },
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" }, // New data
            new Versenyzo { NoiVersenyzo = true, Tav = "Rövid" }  // New data
        };
            int expectedCount = 4; // Updated expected count

            // Act
            int actualCount = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    actualCount++;
                }
            }

            // Assert
            actualCount.Should().Be(expectedCount);
        }
    }

    public class Versenyzo
    {
        public bool NoiVersenyzo { get; set; }
        public string Tav { get; set; }
    }
}