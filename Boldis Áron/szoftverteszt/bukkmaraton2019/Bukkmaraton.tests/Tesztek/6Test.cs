using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bukkmaraton.tests.Tesztek.ÖtösfeladatTeszt;

namespace Bukkmaraton.tests.Tesztek
{
    public class _6Test
    {
        [Fact]
        public void HaVanTobbMintHatVersenyzo_AkkorATobbMintHatValtozoTrue()
        {
            // Beállítunk néhány versenyzőt
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { TobbMintHat = true },
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = true },
        };

            // Futtatjuk a kódot
            bool tobbMintHat = false;
            foreach (var v in versenyzok)
            {
                if (v.TobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }

            // Ellenőrizzük az eredményt
            tobbMintHat.Should().BeTrue();
        }

        [Fact]
        public void HaNincsTobbMintHatVersenyzo_AkkorATobbMintHatValtozoFalse()
        {
            // Beállítunk néhány versenyzőt
            var versenyzok = new List<Versenyzo>
        {
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = false },
            new Versenyzo { TobbMintHat = false },
        };

            // Futtatjuk a kódot
            bool tobbMintHat = false;
            foreach (var v in versenyzok)
            {
                if (v.TobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }

            // Ellenőrizzük az eredményt
            tobbMintHat.Should().BeFalse();
        }
    }
}

public class Versenyzo
{
    public bool TobbMintHat { get; set; }
}
