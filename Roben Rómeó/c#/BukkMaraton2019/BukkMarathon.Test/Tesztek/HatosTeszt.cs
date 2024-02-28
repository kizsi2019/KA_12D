using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMarathon.Test.Tesztek
{
    public class HatosTeszt
    {
        [Fact]
        public void TobbMintHat_Property_Should_Be_True_If_Any_Versenyzok_Have_It()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = true },
            new Versenyzo { TobbMintHat = false }
        };

            bool expected = true; // Expected value of 'tobbMintHat' flag

            // Act
            bool tobbMintHat = false;
            foreach (var item in versenyzok)
            {
                if (item.TobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }

            // Assert
            tobbMintHat.Should().Be(expected);
        }
    }

    public class Versenyzo
    {
        public bool TobbMintHat { get; set; }
    }
}

