// Objektum metódusok

var huba = {
    nev: "Huba",
    kor: 38,
    foglalkozas: "Vezér",
    hazas: true,
    baratok: ["Álmos", "Előd", "Ond"],
    "csaladi allapot": "nős",
    szuletesiEvSzamitas: function() {
        this.szuletesiEv = 2023 - this.kor;
    }
};

huba.szuletesiEvSzamitas();
console.log(huba);