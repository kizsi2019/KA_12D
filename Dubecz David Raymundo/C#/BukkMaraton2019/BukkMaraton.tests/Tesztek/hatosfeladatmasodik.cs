using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace BukkMaraton.tests.Tesztek
{
    public class Versenyzo
    {
        public bool TobbMintHat { get; set; }
    }

    public class VersenyzoHelper
    {
        public static bool HasAnyWithMoreThanSix(List<Versenyzo> versenyzok)
        {
            foreach (var item in versenyzok)
            {
                if (item.TobbMintHat)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class hatosfeladatmasodik
    {
        [Fact]
        public void Test_AnyWithMoreThanSix()
        {
            // Arrange
            List<Versenyzo> versenyzok = new List<Versenyzo>
            {
                new Versenyzo { TobbMintHat = false },
                new Versenyzo { TobbMintHat = false },
                new Versenyzo { TobbMintHat = true },
                new Versenyzo { TobbMintHat = false },
                new Versenyzo { TobbMintHat = true }
            };

            // Act
            bool result = VersenyzoHelper.HasAnyWithMoreThanSix(versenyzok);

            // Assert
            result.Should().BeTrue(); // Elvárjuk, hogy legyen olyan versenyző, aki több mint hat versenyen indult
        }
    }
}
