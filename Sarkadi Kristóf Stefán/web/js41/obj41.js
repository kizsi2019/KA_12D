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
console.log(korok);

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

function jatek(){
    var pont = Math.random() * 10;
    console.log(pont >= 5);
}

jatek();

(function() {
    var pont = Math.random()*10;
    console.log(pont >= 5);
})()

(function(teszt) {
    var pont = Math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
})('Helló!');

function nyugdij(ev) {
    var szoveg = "A nyugdíjazásig hátralévő évek száma! "
    return function(szuletesiEv){
        var datumobjektum = new Date();
        var aktualisEv = datumobjektum.getFullYear();
        var kor =aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdijasUSA = nyugdij(66);
nyugdijasUSA(2004);
nyugdij(66)(2004);

var nyugdijasHUN = nyugdij(65);
var nyugdijasIZL = nyugdij(67);
nyugdijasHUN(2004);
nyugdijasIZL(2004)

/////////
var szamlalo = 0;

function leptet() {
    szamlalo++;
    console.log(szamlalo);
}
leptet()
leptet()
leptet()

var szamlalo = 0;

function leptet() {
    var szamlalo = 0;
    return function() {
        szamlalo++;
        console.log(szamlalo);
    }
}
var hozzaad = leptet();
hozzaad();
hozzaad();
hozzaad();

var leptet = (
    function() {
        var szamlalo = 0;
        return function() {
            szamlalo++;
            console.log(szamlalo);
        }
    }
)();

var odon = {
    nev: 'Ödön',
    kor: 45,
    foglalkozas: 'csillagász',
    udvozlet: function(stilus, napszak) {
        if (stilus === 'hivatalos') {
            console.log('Üdvözlet, jó ' + napszak + ' kivánok!' + this.nev + ' vagyok.');
        } else if (stilus === 'baráti') {
            console.log('Szia, jó ' + napszak + '!');
        }
    }
}

odon.udvozlet('hivatalos', 'hajnalt');
odon.udvozlet('baráti', 'estét');

var bela = {
    nev: 'Béla',
    kor: 62,
    foglalkozas: 'portás'
}

odon.udvozlet.call(bela, 'baráti', 'estét');

odon.udvozlet.apply(bela, ['baráti', 'reggelt']);

var odonBarati = odon.udvozlet.bind(odon, 'baráti');
odonBarati('napot');
odonBarati('estét');

var belaHivatalos = odon.udvozlet.bind(bela, 'hivatalos');
var belaHivatalosReggeli = odon.udvozlet.bind(bela, 'hivatalos', 'reggelit');

belaHivatalos('estét');
belaHivatalosReggeli();*/

var evek = [1954, 1990, 1963, 2000, 2010];

function tombMuvelet(tomb, Fv) {
    var eredmeny = [];
    for (var i = 0; i < tomb.length; i++) {
        eredmeny.push(Fv(tomb[i]));
    }
    return eredmeny;
}

function korszamitas(elem) {
    return 2024 - elem;
}

function felnott(korhatar, elem) {
    return elem >= korhatar;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(evek);
console.log(korok);

var felnottkorJapanban = tombMuvelet(korok, felnott.bind(this, 20));

console.log(felnottkorJapanban);
