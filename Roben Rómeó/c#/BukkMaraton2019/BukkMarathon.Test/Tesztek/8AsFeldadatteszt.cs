using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMarathon.Test.Tesztek
{
    public class _8AsFeldadatteszt
    {
        [Fact]
        public void Calculate_Statistics_Should_Return_Correct_Results()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { Rajtszam = 1, Nev = "John Doe", Egyesulet = "XYZ", Ido = 10.5, Kategoria = "ff", NoiVersenyzo = false },
            new Versenyzo { Rajtszam = 2, Nev = "Jane Doe", Egyesulet = "ABC", Ido = 11.2, Kategoria = "ff", NoiVersenyzo = true },
            new Versenyzo { Rajtszam = 3, Nev = "Bob Smith", Egyesulet = "DEF", Ido = 10.2, Kategoria = "ff", NoiVersenyzo = false },
            new Versenyzo { Rajtszam = 4, Nev = "Alice Smith", Egyesulet = "DEF", Ido = 9.8, Kategoria = "ff", NoiVersenyzo = false },
            new Versenyzo { Rajtszam = 5, Nev = "Eve Smith", Egyesulet = "DEF", Ido = 12.0, Kategoria = "kk", NoiVersenyzo = false },
            new Versenyzo { Rajtszam = 6, Nev = "Mike Johnson", Egyesulet = "GHI", Ido = 11.5, Kategoria = "kk", NoiVersenyzo = false }
        };

            var expectedStats = new Dictionary<string, int>
        {
            { "ff", 3 },
            { "kk", 1 }
        };

            // Act
            var stat = new Dictionary<string, int>();
            foreach (var item in versenyzok)
            {
                if (!item.NoiVersenyzo)
                {
                    if (stat.ContainsKey(item.Kategoria))
                    {
                        stat[item.Kategoria]++;
                    }
                    else
                    {
                        stat.Add(item.Kategoria, 1);
                    }
                }
            }

            // Assert
            stat.Should().BeEquivalentTo(expectedStats);
        }
    }

    public class Versenyzo
    {
        public int Rajtszam { get; set; }
        public string Nev { get; set; }
        public string Egyesulet { get; set; }
        public double Ido { get; set; }
        public string Kategoria { get; set; }
        public bool NoiVersenyzo { get; set; }
    }
}

