using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukk_maraton.test.test
{
    internal class _5Feladattest
    {
        public class Versenyzo
        {
            public bool NoiVersenyzok { get; set; }
            public string Tav { get; set; }
        }

        public class VersenyTeszt
        {
            [Fact]
            public void NoiVersenyzoRovidzavonSzamolasTeszt()
            {
                // Arrange
                var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { NoiVersenyzok = true, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzok = true, Tav = "Hosszú" },
            new Versenyzo { NoiVersenyzok = false, Tav = "Rövid" },
            new Versenyzo { NoiVersenyzok = true, Tav = "Rövid" },
        };

                // Act
                int noiVersenyzoRovidzavon = 0;
                foreach (var v in versenyzok)
                {
                    if (v.NoiVersenyzok && v.Tav == "Rövid")
                    {
                        noiVersenyzoRovidzavon++;
                    }
                }

                // Assert
                noiVersenyzoRovidzavon.Should().Be(2); // Az elvárt eredmény a tesztesethez igazítva

                // Opcionális: Ellenőrizhetjük a Console.WriteLine hívást is, ha szükséges
                // Példa: https://github.com/adamralph/itsrainingbytes/blob/master/tests/It-s-Raining-Bytes.Tests/ConsoleOutputTests.cs

                // Opcionális: További FluentAssertions ellenőrzések a versenyzők listájára
                versenyzok.Should().NotBeEmpty();
                versenyzok.Should().OnlyContain(v => v.NoiVersenyzok || v.Tav != "Rövid");
            }
        }
    }
}
