using Xunit;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton.Tests.Tesztek
{

    public class Hatosfeladat
    {
        [Fact]
        public void TobbMintHatVersenyzo_VanE()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = true },
            new Versenyzo { TobbMintHat = false }
        };
            bool elvartTobbMintHat = true;

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
            tobbMintHat.Should().Be(elvartTobbMintHat, because: "ellenőrizni kell, hogy van-e olyan versenyző, aki több mint hat éve részt vesz a versenyen");
        }
    }
}