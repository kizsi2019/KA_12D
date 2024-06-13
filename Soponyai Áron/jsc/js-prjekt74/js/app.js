// let, const
// ES5
/*
var nev5 = 'Vicc Elek';
var kor5 = 40;

nev5 = 'Abbanapillanatban Debrüi'

console.log(nev5);

function nyelvVizsga5(siker) {
    if (siker) {
        var keresztnev = 'Gizi';
        var szuletesiEv = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}
nyelvVizsga5(true);


// ES6

const nev6 = 'Fing Ottam';
let kor6 = 40;

// nev6 = 'Kiss Pista'; // Hibát dob
// console.log(nev6);

function nyelvVizsga6(siker) {
    if (siker) {
        var keresztnev = 'Trottyos';
        const szuletesiEv = 1985;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}
nyelvVizsga6(true);


let i = 9;
for (let i = 0; i < 5; i++) {
    console.log(i);
}
console.log(i);

var i = 9;
for (var i = 0; i < 5; i++) {
    console.log(i);
}
console.log(i);


////////////////////////////////////////////////////////////////
// Blokkok és IIFE
// ES6

{
    const a = 1;
    let b = 2;
    // var c = 3;
}
// console.log(a + b);

// ES5

(function() {
    let c = 3;
    console.log(c);
})();
console.log(c);


////////////////////////////////////////////////////////////////
// Sztringek ES6-ban

let vezetekNev = 'Micc';
let keresztNev = 'Elek';

const szuletesiEv = 1970;

function korszamitas(ev) {
    return 2024 - ev;
}

// ES5
console.log(vezetekNev + ' ' + keresztNev + ' ' + szuletesiEv + '-ben született. Most ' + korszamitas(szuletesiEv) + ' éves.');

// ES6
console.log(`${vezetekNev} ${keresztNev}, született ${szuletesiEv}-ben. Most ${korszamitas(szuletesiEv)} éves.`);

const nev = `${vezetekNev} ${keresztNev}`;

console.log(nev.startsWith('M'));
console.log(nev.endsWith('ek'));
console.log(nev.includes('icc'));
console.log(vezetekNev.repeat(3));
console.log(`${vezetekNev} `.repeat(3));


////////////////////////////////////////////////////////////////
// Nyíl függvények

const evek = [1970, 1975, 1954, 2010, 1981];

// ES5
var korokES5 = evek.map(function(elem) {
    return 2024 - elem;
});
console.log(korokES5);

// ES6
let korokES6 = evek.map(elem => 2024 - elem);
console.log(korokES6);

korokES6 = evek.map((elem, index) => `Kor ${index}: ${2024 - elem}.`);
console.log(korokES6);

korokES6 = evek.map((elem, index) => {
    const aktEv = new Date().getFullYear();
    const kor = aktEv - elem;
    return `Kor ${index}: ${kor},`;
});
console.log(korokES6);

const dobozES62 = {
    var obj = this;
    szin:'zöld',
    pozicio:1,
    kattintsRam: () => {
        document.querySelector('.green').addEventListener('click', () => {
            var szoveg = 'Én vagyok a(z) ' + obj.pozicio + '. doboz és színem ' + obj.szin + '.';
            alert(szoveg);
        })
    }
};

dobozES62.kattintsRam();


function Szemely(mev) {
    this.nev = nev;
}

Szemely.prototype.barataimESS = function(haverok) {
    console.log(this.nev);
    var obj = this;
    var tomb = haverok.map(function(elem) {
        return obj.nev + ' barátja ' + elem + '.';
    });
    console.log(tomb);
}

var haverok = ['Jóska', 'Pista', 'Ödön'];
new Szemely('Géza').barataimESS(haverok);

Szemely.prototype.barataimES6 = function(haverok) {
    const tomb = haverok.map(elem =>
        '${this.nev} barátja ${elem.}'
    );
    console.log(tomb);
}


var odon = ['Ödön', 50]
var nev = odon[0];
var kor = odon[1];

console.log(nev2);
console.log(kor2);

var dobozokTombES5 = Array.prototype.slice.call(dobozok)

    dobozokTombES5.forEach(function(aktualis{
        aktualis.style.backgroundColor = 'orange';
    }))
        
    });
*/

