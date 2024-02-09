// Objektum létrehozása

/*var odon = {
    nev: "Ödön",
    sszuletesiEv: 1978,
    foglalkozas: "grafikus"
}; 

var Szemely = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
    this.korszamitas = function(){
        console.log(2024 - this.szuletesiEv);
    }
};

Szemely.prototype.korszamitas = function() {
    console.log(2024 - this.szuletesiEv);
}

Szemely.prototype.teszt = 'teszt';

var odon = new Szemely("Ödön", 1979, "grafikus")
odon.korszamitas();

var erzsi = new Szemely("Erzsi", 1950, "nyugdíjas")
erzsi.korszamitas();

console.log(Szemely);
console.log(odon);

console.log(odon.teszt);

var evek = [1954, 1998, 1963, 2000, 2010];
function tombMuvelet(tomb, tv) {
    var eredmeny = [];
    for (var i = 0; i < tomb.Length; i++) {
        eredmeny.push(tv(tomb[i]));
    }
    return eredmeny;
}

function felnott(elem) {
    return elem >= 18;
}

function korszamitas(elem) {
    return 2024 - elem;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(korok);*/

function interjukerdes(foglalkozas) {
    if (foglalkozas == 'tanár') {
        return function(nev) {
            console.log(nev + ', megtudná mondani, hogy milyen tárgyakat tanít?')
        }
    } else if (foglalkozas == 'elado') {
        return function(nev) {
            console.log(nev + ', hogyan kezeli egy vevő reklamációját?')
        }
    } else {
        console.log('Mi a foglalkozása kedves ' + nev + '?')
    }
}

var kerdesTanaroknak = interjukerdes('tanár');
kerdesTanarokmak('Pál');

var kerdesEladoknak = interjukerdes('elado');
kerdesEladoknak('Teri')
kerdesEladoknak('Feri')
kerdesEladoknak('Ági')

interjukerdes('tanár')('Péter');
interjukerdes('programozó')('Ödön');
