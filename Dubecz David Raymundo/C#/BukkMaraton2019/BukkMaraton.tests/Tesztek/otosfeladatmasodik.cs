using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton.Tests.Tesztek
{
    public class otosfeladatmasodik
    {
        [Test]
        public void NoiVersenyzoRovidTavonSzama()
        {
            // Adott
            var versenyzok = new List<Versenyzo>
            {
                new Versenyzo {NoiVersenyzo = true, Tav = "Rövid"},
                new Versenyzo {NoiVersenyzo = false, Tav = "Rövid"},
                new Versenyzo {NoiVersenyzo = true, Tav = "Hosszú"},
                new Versenyzo {NoiVersenyzo = false, Tav = "Hosszú"},
            };

            // Elvárt
            var elvartNoiVersenyzoRovidTavonSzama = 1;

            // Amikor
            var noiVersenyzoRovidTavonSzama = 0;
            foreach (var item in versenyzok)
            {
                if (item.NoiVersenyzo && item.Tav == "Rövid")
                {
                    noiVersenyzoRovidTavonSzama++;
                }
            }

            // Akkor
            noiVersenyzoRovidTavonSzama.Should().Be(elvartNoiVersenyzoRovidTavonSzama);
        }
    }

    public class Versenyzo
    {
        public bool NoiVersenyzo { get; set; }
        public string Tav { get; set; }
    }
}
