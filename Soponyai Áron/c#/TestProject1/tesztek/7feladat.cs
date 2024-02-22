using Xunit;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton.Tests.Tesztek
{
    public class feladat7
    {
        [Fact]
        public void GyoztesFelnottFerfiRovidTav_KivalasztasHelyes()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { Tav = "Hosszú", Kategoria = "ff", Ido = 120, Rajtszam = 1, Nev = "Teszt Elek", Egyesulet = "Test Egyesület" },
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Ido = 110, Rajtszam = 2, Nev = "Kovács János", Egyesulet = "Példa Egyesület" },
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Ido = 115, Rajtszam = 3, Nev = "Nagy Gábor", Egyesulet = "Példa Egyesület" },
            new Versenyzo { Tav = "Rövid", Kategoria = "ff", Ido = 105, Rajtszam = 4, Nev = "Kiss István", Egyesulet = "Példa Egyesület" }
        };
            var elvartGyoztes = new Versenyzo { Tav = "Rövid", Kategoria = "ff", Ido = 105, Rajtszam = 4, Nev = "Kiss István", Egyesulet = "Példa Egyesület" };

            // Act
            Versenyzo gyoztesFelnottFerfiRovidTav = null;
            foreach (var item in versenyzok)
            {
                if (item.Tav == "Rövid" && item.Kategoria == "ff")
                {
                    if (gyoztesFelnottFerfiRovidTav == null)
                    {
                        gyoztesFelnottFerfiRovidTav = item;
                    }
                    else
                    {
                        if (item.Ido < gyoztesFelnottFerfiRovidTav.Ido)
                        {
                            gyoztesFelnottFerfiRovidTav = item;
                        }
                    }
                }
            }

            // Assert
            gyoztesFelnottFerfiRovidTav.Should().NotBeNull("mivel van győztes felnőtt férfi rövid távon");
            gyoztesFelnottFerfiRovidTav.Should().BeEquivalentTo(elvartGyoztes, options => options.ExcludingMissingMembers(), "a győztesnek meg kell egyeznie az elvárt értékekkel");
        }
    }
}
