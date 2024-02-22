using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukk_maraton.test.test
{
    internal class _6FeladatTest
    {
        public class Versenyzo
        {
            public bool NoiVersenyzok { get; set; }
            public string Tav { get; set; }
            public TimeSpan Ido { get; private set; }
            public bool tobbMintHat
            {

                get
                {
                    return Ido > new TimeSpan(6, 0, 0);
                }
                
            }

        }

        public class VersenyTeszt
        {
            [Fact]
            public void TobbMintHatVersenyzoSzamolasTeszt()
            {
                // Arrange
                var versenyzok = new List<Versenyzo>
        {
         
        };

                // Act
                bool tobbMintHat = false;
                foreach (var v in versenyzok)
                {
                    if (v.tobbMintHat)
                    {
                        tobbMintHat = true;
                        break;
                    }
                }

                // Assert
                tobbMintHat.Should().BeTrue(); // Az elvárt eredmény a tesztesethez igazítva

                // Opcionális: Ellenőrizhetjük a Console.WriteLine hívást is, ha szükséges
                // Példa: https://github.com/adamralph/itsrainingbytes/blob/master/tests/It-s-Raining-Bytes.Tests/ConsoleOutputTests.cs

                // Opcionális: További FluentAssertions ellenőrzések a versenyzők listájára
                versenyzok.Should().NotBeEmpty();
                versenyzok.Should().ContainSingle(v => v.tobbMintHat);
            }
        }
       
    }


}
