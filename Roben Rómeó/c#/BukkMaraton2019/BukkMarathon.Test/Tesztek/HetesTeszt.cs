using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMarathon.Test.Tesztek
{
    public class HetesTeszt
    {
        [Fact]
        public void Find_Winner_Adult_Male_Short_Distance_Should_Return_Correct_Versenyzo()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { Rajtszam = 1, Nev = "John Doe", Egyesulet = "XYZ", Ido = 10.5, Tav = "Rövid", Kategoria = "ff" },
            new Versenyzo { Rajtszam = 2, Nev = "Jane Doe", Egyesulet = "ABC", Ido = 11.2, Tav = "Rövid", Kategoria = "ff" },
            new Versenyzo { Rajtszam = 3, Nev = "Bob Smith", Egyesulet = "DEF", Ido = 10.2, Tav = "Rövid", Kategoria = "ff" }
        };

            var expectedWinner = new Versenyzo { Rajtszam = 3, Nev = "Bob Smith", Egyesulet = "DEF", Ido = 10.2, Tav = "Rövid", Kategoria = "ff" };

            // Act
            Versenyzo gyoztesFelnottFerfiRovidTav = null;
            foreach (var item in versenyzok)
            {
                if (item.Tav == "Rövid" && item.Kategoria == "ff")
                {
                    if (gyoztesFelnottFerfiRovidTav == null || item.Ido < gyoztesFelnottFerfiRovidTav.Ido)
                    {
                        gyoztesFelnottFerfiRovidTav = item;
                    }
                }
            }

            // Assert
            gyoztesFelnottFerfiRovidTav.Should().BeEquivalentTo(expectedWinner);
        }
    }

    public class Versenyzo
    {
        public int Rajtszam { get; set; }
        public string Nev { get; set; }
        public string Egyesulet { get; set; }
        public double Ido { get; set; }
        public string Tav { get; set; }
        public string Kategoria { get; set; }
    }
}

