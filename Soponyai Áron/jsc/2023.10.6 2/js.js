var nev1='Ond';
var nev2='Kond';
var nev3='Tas';

var nevek=['Ond','Kond','Tas'];

var korok =new Array(35,42,38);

console.log(korok[1]);
console.log(nevek);
console.log(nevek.length);

nevek[1]='Huba';
console.log(nevek);

var huba = ['Huba',38,'vezér',true];
console.log(huba);

huba.push(42);
console.log(huba);

huba.unshift("ifj");
console.log(huba);

huba.pop();
console.log(huba);

huba.shift();
console.log(huba);

console.log(huba.indexOf(48));

var szakacs = huba.indexOf("szakacs") === -1 ? "Huba nem szakacs" : "Huba szakacs";
console.log(szakacs);

var h = {
    nev: "Huba",
    életkor: 38
};

var hubas = {
    nev: "Huba",
    kor: 38,
    foglalkozás: "vezér",
    hazas: true,
    baratok: ['Álmos', 'Előd', 'Ond', 'Kond'],
    "csaladi allapot": nős
};

console.log(hubas.foglalkozás);
console.log(hubas.nev);

var k = 'hazas';
console.log(hubas['nev']);

console.log(hubas[k]);

console.log(hubas['csaladi allapot']);

hubas['kor'] = 40;
hubas.foglalkozás = "ács";

console.log(hubas);

var tas = new Object();
tas.nev = "Tas";
tas.kor = 32;
tas['foglalkozás'] = "vezér";
console.log(tas);