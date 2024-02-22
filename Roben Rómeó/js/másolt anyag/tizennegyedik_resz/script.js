// Objektumok és tulajdonságok

/*
var h = {
    nev: "Huba",
    "elet kor": 38
};
*/

var huba = {
    nev: "Huba",
    kor: 38,
    foglalkozas: "Vezér",
    hazas: true,
    baratok: ["Álmos", "Előd", "Ond"],
    "csaladi allapot": "nős"
};

console.log(huba.foglalkozas);
console.log(huba["nev"]);

var h = "hazas";
console.log(huba[h]);

console.log(huba["csaladi allapot"]);

huba["kor"] = 40;
huba.foglalkozas = "Ács";

console.log(huba);

var tas = new Object();

tas.nev = "Tas";
tas.kor = 32;
tas["foglalkozas"] = "Vezér";
console.log(tas);