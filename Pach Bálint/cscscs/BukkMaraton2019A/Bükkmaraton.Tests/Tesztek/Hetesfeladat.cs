using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bükkmaraton.Tests.Tesztek
{
    internal class Hetesfeladat
    {
        public void GyoztesFerfiRovidTav_WhenVersenyzokGiven_ShouldReturnCorrectWinner()
        {
            // Arrange
            var versenyzok = new[]
            {
            new Versenyzo { Rajtszam = 1, Nev = "Versenyzo1", Egyesulet = "Egyesulet1", Ido = new TimeSpan(0, 10, 30) },
            new Versenyzo { Rajtszam = 2, Nev = "Versenyzo2", Egyesulet = "Egyesulet2", Ido = new TimeSpan(0, 9, 45) },
            new Versenyzo { Rajtszam = 3, Nev = "Versenyzo3", Egyesulet = "Egyesulet3", Ido = new TimeSpan(0, 11, 15) },
        };

            // Act
            Versenyzo gyoztesFerfiRovidTav = null;
            foreach (var v in versenyzok)
            {
                if (gyoztesFerfiRovidTav == null || v.Ido < gyoztesFerfiRovidTav.Ido)
                {
                    gyoztesFerfiRovidTav = v;
                }
            }

            // Assert
            gyoztesFerfiRovidTav.Should().NotBeNull();
            gyoztesFerfiRovidTav.Nev.Should().Be("Versenyzo2"); // A második versenyző nyer
            gyoztesFerfiRovidTav.Egyesulet.Should().Be("Egyesulet2");
            gyoztesFerfiRovidTav.Rajtszam.Should().Be(2);
            gyoztesFerfiRovidTav.Ido.Should().Be(new TimeSpan(0, 9, 45));
        }
    }

    public class Versenyzo
    {
        public int Rajtszam { get; set; }
        public string Nev { get; set; }
        public string Egyesulet { get; set; }
        public TimeSpan Ido { get; set; }
    }
}

