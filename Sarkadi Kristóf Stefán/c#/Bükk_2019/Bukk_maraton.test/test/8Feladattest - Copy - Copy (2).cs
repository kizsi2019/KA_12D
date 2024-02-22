using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukk_maraton.test.test
{
    internal class _8FeladatTest
    {
        public class Versenyzo
        {
            public bool NoiVersenyzok { get; set; }
            public string Tav { get; set; }
            public string kategoria { get; set; }
        }

        public class _8VersenyTeszt
        {
            [Fact]
            public void StatisztikaTeszt()
            {
                // Arrange
                var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { NoiVersenyzok = true, kategoria = "A" },
            new Versenyzo { NoiVersenyzok = false, kategoria = "B" },
            new Versenyzo { NoiVersenyzok = false, kategoria = "A" },
            new Versenyzo { NoiVersenyzok = false, kategoria = "B" },
            // További versenyzők hozzáadása a teszthez a megfelelő tulajdonságokkal
        };

                // Act
                Dictionary<string, int> stat = new Dictionary<string, int>();
                foreach (var v in versenyzok)
                {
                    if (!v.NoiVersenyzok)
                    {
                        if (stat.ContainsKey(v.kategoria))
                        {
                            stat[v.kategoria]++;
                        }
                        else
                        {
                            stat.Add(v.kategoria, 1);
                        }
                    }
                }

                // Assert
                stat.Should().NotBeEmpty(); // A statisztikának nem szabad üresnek lennie

                stat.Should().ContainKey("A"); // Az elvárt eredmény a tesztesethez igazítva
                stat.Should().ContainKey("B");

                stat["A"].Should().Be(2); // Az elvárt eredmény a tesztesethez igazítva
                stat["B"].Should().Be(2);

                // Opcionális: Ellenőrizhetjük a Console.WriteLine hívást is, ha szükséges
                // Példa: https://github.com/adamralph/itsrainingbytes/blob/master/tests/It-s-Raining-Bytes.Tests/ConsoleOutputTests.cs
            }
        }
    }
}
