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
*/

////////////////////////////////////////////////////////////////
// Nyíl függvények 2.

// ES5

/*var dobozES62 = {
    szin: 'zöld',
    pozicio: 1,
    kattintsRam: () => {
        document.querySelector('.green').addEventListener('click', () => {
            var szoveg = 'Én vagyok az ' + this.pozicio + ' doboz, a színem ' + this.szin + '.';
            alert(szoveg);
        })
    }
}

dobozES62.kattintsRam();

function Szemely(nev) {
    this.nev = nev;
}

Szemely.prototype.barataimES5 = function(haverok) {
    console.log(this.nev);
    var obj = this;
    var tomb = haverok.map(function(elem) {
        return obj.nev + ' barátja ' + elem + ',';
    });
    console.log(tomb);
}

var haverok = ['Joska', 'Pista',  'Ödön'];
new Szemely('Géza').barataimES5(haverok)

Szemely.prototype.barataimES5 = function(haverok) {
    const tomb = haverok.map(elem =>
        ´$(this.nev) barátja $(elem).´    
    );
}
new Szemely('Géza').barataimES5(haverok);

//ES5
var odon = ['Ödön', 50];
var nev = odon[0];
var kor = odon[1];
console.log(nev);
console.log(kor);

//ES6
const [nev2, kor2] = ['Ödön', 50];
console.log(nev2);
console.log(kor2);

const obj = {
    keresztNev: 'Ödön',
    vezetekNev: 'Gödön'
};
const {keresztNev, vezetekNev} = obj;
console.log(keresztNev);
console.log(vezetekNev);

const {keresztNev: x, vezetekNev: y} = obj;
console.log(x);
console.log(y);

function korEsnyugdij(szuletesiEv) {
    let nyugdijKorhatar = 65;
    const kor = new Date().getFullYear() - szuletesiEv;

    return [kor, nyugdijKorhatar - kor];
}
const [kor, nyugdijKorhatar]*/


//es5
const dobozok = document.querySelectorAll('.rectengle');

var dobozokTombes5 = Array.prototype.slice.call(dobozok);
dobozokTombes5.forEach(aktualis => aktualis.background = 'orange');


for (var i = 0; i < dobozokTombes5; i++) {
    if (dobozokTombes5[i].className === 'rectengle blue') {
        continue;
    }
    dobozokTombes5[i].textcontent = 'Kék lettem';
}

//es6
for (const aktualis of dobozokTombes5) {
    if (dobozokTombes5[i].className === 'rectengle blue') {
        continue;
    }
    dobozokTombes5[i].textcontent = 'Kék lettem';
};

for (const aktualis of dobozokTombes5) {
    if (dobozokTombes5[i].className === 'rectengle blue') {
        continue;
    }
    dobozokTombes5[i].textcontent = 'Kék lettem';
};



/*//es5
var kotok = [2, 10, 20, 17, 16];
console.log(kotok);

var felnottek = kotok.map(function(aktualis) {
    return aktualis;
});

console.log(felnottek);

console.log(felnottek.indexOf(true));

//es6
console.log(korok.findenex(aktualis => 18));
console.log(korok.find(aktualis => aktualis >= 18));*/



function szamok(a, b, c, d) {
    return a + b + c + d;
}

var osszeg = szamok(1, 2, 3, 4);
console.log(osszeg);

//es5
var szamokTomb = [1, 2, 3, 4];
var osszeg2 = szamok.apply(null, szamokTomb);

console.log(osszeg2);


//es6
const osszeg3 = szamok(...szamokTomb);
console.log(osszeg3);

const t2 = [5, 6, 7, 8, 9, 10];

const t3 = [...szamokTomb, ...t2];
console.log(t3);

const cimsor = document.querySelector('h1');

const htmlElemek = [cimsor, ...dobozok];

Array.from(htmlElemek).forEach(aktualisElem => aktualisElem.style.color = 'purple')