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