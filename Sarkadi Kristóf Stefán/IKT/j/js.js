/*var h = {
    nev: 'Huba',
    'elet kor' : 38
};*/

var huba = {
    nev: 'Huba',
    kor: '38',
    foglalkozas: 'vezér',
    hazas: true,
    baratok: ['Álmos', 'Előd', 'Ond'],
    'csaladi allapota': 'nős'
};

console.log(huba.foglalkozas);
console.log(huba['vev']);

var h = 'hazas';
console.log(huba[h]);

console.log(huba['csaladi allapota']);

huba['kor'] = 40;
huba.foglalkozas = 'ács';

console.log(huba);

var tas = new Object();

tas.nev = 'Tas';
tas.kor = 32;
tas['foglalkozas'] = 'vezér';
console.log(tas);