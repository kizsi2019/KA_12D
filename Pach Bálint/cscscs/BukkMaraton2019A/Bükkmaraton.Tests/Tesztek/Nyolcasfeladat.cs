using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bükkmaraton.Tests.Tesztek
{
    public class Nyolcasfeladat
    {
        [Fact]
        public void Statisztika_WhenVersenyzokGiven_ShouldCorrectlyCountNonNoiVersenyzoByKategoria()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { Kategoria = "Junior", NoiVersenyzo = false },
            new Versenyzo { Kategoria = "Open", NoiVersenyzo = true },
            new Versenyzo { Kategoria = "Junior", NoiVersenyzo = false },
            new Versenyzo { Kategoria = "Master", NoiVersenyzo = false },
            new Versenyzo { Kategoria = "Open", NoiVersenyzo = false }
        };

            var expectedStat = new Dictionary<string, int>
        {
            { "Junior", 2 }, 
            { "Master", 1 },
            { "Open", 1 }
        };

            // Act
            Dictionary<string, int> stat = new Dictionary<string, int>();
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

            // Assert
            stat.Should().BeEquivalentTo(expectedStat);
        }
        public class Versenyzo
        {
            public int Rajtszam { get; set; }
            public string Nev { get; set; }
            public string Egyesulet { get; set; }
            public TimeSpan Ido { get; set; }
        }
    }
}
