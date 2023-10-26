var huba = {
    nev: "huba",
    kor: 40,
    foglalkozas: "vezér",
    hazas: true,
    baratok: ["Álmos", "Előd", "Ond"],
    "csaladi allapot": "nős",
    szuletesiEvszamitas: function(){
        this.szuletesiEv = 2023 - this.kor;
    }
};

huba.szuletesiEvszamitas();
console.log(huba);