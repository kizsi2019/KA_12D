using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukkmaraton.Tests.Tesztek
{
    public class hetesfeladat
    {
        [Fact]
        public void CheckFastestAdultMaleShortDistanceRunner_ReturnsWinnerDetails()
        {
            // Arrange
            var versenyzok = new versenyzok(); // vagy bármi, amivel inicializáljuk a versenyzők listáját
                                               // Itt inicializálhatjuk a szükséges versenyzőket a teszteléshez

            // Act
            Versenyzok gyoztesFerfiRovidTav = null;
            foreach (var v in versenyzo)
            {
                if (v.Kategoria == "ff" && v.Tav == "Rövid")
                {
                    if (gyoztesFerfiRovidTav == null || v.Ido < gyoztesFerfiRovidTav.Ido)
                    {
                        gyoztesFerfiRovidTav = v;
                    }
                }
            }

            // Assert
            Assert.NotNull(gyoztesFerfiRovidTav); // Győztes felnőtt férfi rövid távú versenyzőt találtunk
            Assert.True(gyoztesFerfiRovidTav.Kategoria == "ff"); // Győztes felnőtt férfi kategória
            Assert.True(gyoztesFerfiRovidTav.Tav == "Rövid"); // Győztes rövid távú versenyző
            Console.WriteLine("7. feladat: A felnőtt férfi (ff) kategória győztese rövid távon:");
            Console.WriteLine($"\tRajtszám: {gyoztesFerfiRovidTav.Rajtszam}");
            Console.WriteLine($"\tNév: {gyoztesFerfiRovidTav.Nev}");
            Console.WriteLine($"\tEgyesület: {gyoztesFerfiRovidTav.Egyesulet}");
            Console.WriteLine($"\tIdő: {gyoztesFerfiRovidTav.Ido}");
        }
    }
}
