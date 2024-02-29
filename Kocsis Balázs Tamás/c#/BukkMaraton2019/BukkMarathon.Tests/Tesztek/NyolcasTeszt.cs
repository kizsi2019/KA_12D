using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace BukkMarathon.Tests.Tesztek
{
    public class NyolcasTeszt
    {
        public class Versenyzo
        {
            public bool NoiVersenyzo { get; set; }
            public string Kategoria { get; set; }
        }

        public class Tesztek
        {
            [Fact]
            public void StatisztikaTeszt()
            {
                // Arrange
                var versenyzok = new[]
                {
            new Versenyzo { NoiVersenyzo = true, Kategoria = "K1" },
            new Versenyzo { NoiVersenyzo = false, Kategoria = "K2" },
            new Versenyzo { NoiVersenyzo = false, Kategoria = "K1" },
            new Versenyzo { NoiVersenyzo = false, Kategoria = "K2" },
            // ... további versenyzők
        };

                // Act
                var stat = GetStatisztika(versenyzok);

                // Assert
                stat.Should().NotBeNull().And.HaveCount(2, "Két kategória van a statisztikában.");

                stat.Should().ContainKey("K1").And.ContainValue(2, "K1 kategóriában két férfi versenyző van.");
                stat.Should().ContainKey("K2").And.ContainValue(2, "K2 kategóriában két férfi versenyző van.");
            }

            private Dictionary<string, int> GetStatisztika(Versenyzo[] versenyzok)
            {
                var stat = new Dictionary<string, int>();

                foreach (var v in versenyzok)
                {
                    if (!v.NoiVersenyzo)
                    {
                        if (stat.ContainsKey(v.Kategoria))
                        {
                            stat[v.Kategoria]++;
                        }
                        else
                        {
                            stat.Add(v.Kategoria, 1);
                        }
                    }
                }

                return stat;
            }
        }
    }
}
