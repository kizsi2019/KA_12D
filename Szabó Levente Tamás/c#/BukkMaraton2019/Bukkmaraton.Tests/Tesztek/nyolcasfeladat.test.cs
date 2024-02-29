using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukkmaraton.Tests.Tesztek
{
    public class nyolcasfeladat
    {
        [Fact]
        public void CheckStatistics_ReturnsCorrectStats()
        {
            // Arrange
            var versenyzok = new Versenyzok(); // vagy bármi, amivel inicializáljuk a versenyzők listáját
                                               // Itt inicializálhatjuk a szükséges versenyzőket a teszteléshez

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
            Assert.NotEmpty(stat); // A statisztika nem üres
            Console.WriteLine("8. feladat: Statisztika");
            foreach (var s in stat)
            {
                Console.WriteLine($"Kategória: {s.Key}, Versenyzők száma: {s.Value}");
            }
        }
    }
}