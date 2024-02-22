using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukk_maraton.test.test
{
    internal class _7FeladatTest
    {

        public class Versenyzo
        {
            public bool NoiVersenyzok { get; set; }
            public string Tav { get; set; }
            public string tav { get; set; }
            public string kategoria { get; set; }
            public int rajtszam { get;  set; }
            public string nev { get; set; }
            public string egyesulet { get; set; }
            public TimeSpan ido { get; set; }
        }

        public class VersenyTeszt
        {
            [Fact]
            public void GyoztesFerfiRovidTavTeszt()
            {
                // Arrange
                var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { tav = "Rövid", kategoria = "ff", rajtszam = 1, nev = "Versenyzo1", egyesulet = "Egyesulet1", ido = TimeSpan.FromMinutes(10) },
            new Versenyzo { tav = "Hosszú", kategoria = "ff", rajtszam = 2, nev = "Versenyzo2", egyesulet = "Egyesulet2", ido = TimeSpan.FromMinutes(12) },
            // További versenyzők hozzáadása a teszthez a megfelelő tulajdonságokkal
        };

                // Act
                Versenyzo gyoztesFerfiRovidTav = null;
                foreach (var v in versenyzok)
                {
                    if (v.tav == "Rövid" && v.kategoria == "ff")
                    {
                        if (gyoztesFerfiRovidTav == null)
                        {
                            gyoztesFerfiRovidTav = v;
                        }
                        else
                        {
                            if (v.ido < gyoztesFerfiRovidTav.ido)
                            {
                                gyoztesFerfiRovidTav = v;
                            }
                        }
                    }
                }

                // Assert
                gyoztesFerfiRovidTav.Should().NotBeNull(); // A győztesnek nem szabad nullnak lennie

                gyoztesFerfiRovidTav.rajtszam.Should().Be(1); // Az elvárt eredmény a tesztesethez igazítva
                gyoztesFerfiRovidTav.nev.Should().Be("Versenyzo1");
                gyoztesFerfiRovidTav.egyesulet.Should().Be("Egyesulet1");
                gyoztesFerfiRovidTav.ido.Should().Be(TimeSpan.FromMinutes(10));

                // Opcionális: Ellenőrizhetjük a Console.WriteLine hívást is, ha szükséges
                // Példa: https://github.com/adamralph/itsrainingbytes/blob/master/tests/It-s-Raining-Bytes.Tests/ConsoleOutputTests.cs

                // Opcionális: További FluentAssertions ellenőrzések a versenyzők listájára
                versenyzok.Should().NotBeEmpty();
                versenyzok.Should().OnlyContain(v => v.tav != "Rövid" || v.kategoria != "ff" || v.ido >= gyoztesFerfiRovidTav.ido);
            }
        }
    }
}
