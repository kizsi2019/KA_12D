// objektum létrehozása

/*
var odon = {
    nev: 'Ödön',
    szuletesiEv: '1978',
    foglalkozas: 'Grafikus'
};
*/

/*var Szemely = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
    /*
    this.korSzamitas = function() {
        console.log(2024 - this.szuletesiEv);
    };
    */
    /*};

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
console.log(odon.teszt);*/

var evek = [1954, 1990, 1963, 2000, 2010];

function tombMuvelet(tomb, fv) {
    var eredmeny = [];

    for (var i = 0; i < tomb.lenght; i++) {
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}

function korszamitas(elem) {
    return 2024 - elem;
}

function felnott(elem){
    return elem >= 18;
}


var korok = tombMuvelet(evek, korszamitas);
console.log(korok);

var felnottek = tombMuvelet(korok, felnott);
console.log(felnottek);