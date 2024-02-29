using Xunit;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton.Tests.Tesztek
{
    public class feladat8
    {
        [Fact]
        public void StatisztikaSzamolasHelyes()
        {
            // Arrange
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { NoiVersenyzo = true, Kategoria = "A" },
            new Versenyzo { NoiVersenyzo = false, Kategoria = "A" },
            new Versenyzo { NoiVersenyzo = false, Kategoria = "B" },
            new Versenyzo { NoiVersenyzo = false, Kategoria = "C" },
            new Versenyzo { NoiVersenyzo = false, Kategoria = "B" },
            new Versenyzo { NoiVersenyzo = true, Kategoria = "C" }
        };
            var elvartStatisztika = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
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
            stat.Should().BeEquivalentTo(elvartStatisztika, "a statisztikának helyesen kell számolnia a kategóriákat");
        }
    }
}