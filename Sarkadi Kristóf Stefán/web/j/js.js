/*var h = {
    nev: 'Huba',
    'elet kor' : 38
};*/

/*var huba = {
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
console.log(tas);*/

var huba = {
    neve: 'Huba',
    kor: 38,
    foglalkozása: 'vezér',
    hazas: true,
    baratok: ['Álmos', 'Előd', 'Ond'],
    'családi állapot': 'nős',
    szuletesiEvSzamitas: function() {
        return 2023 - this.kor;
    }
};

huba.szuletesiEv = huba.szuletesiEvSzamitas();
console.log(huba);