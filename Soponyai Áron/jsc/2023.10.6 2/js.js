var huba = {
    nev: "Huba",
    kor: 38,
    foglalkozás: "vezér",
    hazas: true,
    baratok: ['Álmos', 'Előd', 'Ond', 'Kond'],
    "csaladi allapot": "nős",
    szuletesievszamitas: function() {
        this.szuletesiev = 2023 - this.kor;
    }
};

huba.szuletesievszamitas();

console.log(huba)

