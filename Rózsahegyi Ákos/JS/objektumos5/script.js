// objektum létrehozása

/*
var odon = {
    nev: 'Ödön',
    szuletesiEv: '1978',
    foglalkozas: 'Grafikus'
};

var Szemely = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
    
    this.korSzamitas = function() {
        console.log(2024 - this.szuletesiEv);
    };
    
};

Szemely.prototype.korSzamitas = function() {
    console.log(2024 - this.szuletesiEv);
};

Szemely.prototype.teszt = "teszt";

var odon = new Szemely("Ödön", 1979, "Grafikuss");
var erzsi = new Szemely("Erzsi", 1924, "Nyugger");
odon.korSzamitas();
erzsi.korSzamitas();

console.log(Szemely);
console.log(odon);
console.log(odon.teszt);
*/

// függvények
/* var
- A függvény az Object típus egy példánya
- Emiatt a függvény úgy viselkedik, mint bármelyik másik objektum
- Egyetlen változóban tárolhatunk egy egész függvényt
- Egy függvényt átadhatunk egy másik függvénynek mint paramétert
- Ez utóbbihoz hasonló, hogy egy függvény visszatérési értéke lehet egy függvény is,
nem csak szimpla érték, vagy objektum, vagy éppen semmi
*/

/*
var evek = [1954, 1990, 1963, 2000, 2010];

// Első osztályú függvény: Függvény, ami függvényt tartalmaz
function tombMuvelet(tomb, fv) {
    var eredmeny = [];

    for (var i = 0; i < tomb.length; i++) {
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}

function korSzamitas(elem) {
    return 2024 - elem;
}

function felnott(elem) {
    return elem >= 18;
}

var korok = tombMuvelet(evek, korSzamitas);
console.log(korok);

var felnottek = tombMuvelet(korok, felnott);
console.log(felnottek);


// Visszaadott függvények

function interjuKerdes(foglalkozas) {
    if (foglalkozas == 'tanár') {
        return function(nev) {
            console.log(nev + ", meg tudná mondani, hogy milyen tárgyakat tanít?")
        }
    } else if (foglalkozas == 'eladó') {
        return function(nev) {
            console.log(nev + ", hogyan kezel egy vevő reklamációt?")
        }
    } else {
        return function(nev) {
            console.log("Mi a foglalkozása kedves " + nev + "?")
        }
    }
}

var kerdesTanaroknak = interjuKerdes("tanár");
kerdesTanaroknak("Babi néni");

var kerdesEladoknak = interjuKerdes("eladó");
kerdesEladoknak("Pál Kiszopál");

interjuKerdes("tanár")("Péter");
interjuKerdes("programozó")("Ödön");


// Meghívódó függvény - IIFE

function Jatek() {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
}

Jatek();

(function() {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
})();
*/

(function(teszt) {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
})("Hello");