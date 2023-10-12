var nev1 = 'miko'
var nev2 = 'botan'
var nev3 = 'ame'

var nevek = ['miko', 'botan', 'ame'];
var korok = new Array(32, 42, 38);

console.log(korok[1]);
console.log(nevek);
console.log(nevek.length);

nevek[1] = 'miko';
console.log(nevek);

//nevek[5] = 'botan';

nevek[nevek.length] = 'botan';
console.log(nevek);
var ame =
{
    nev: 'ame',
    kor: 20,
    foglalkozas: '',
    hazas: true,
    baratok: ['gura'],
    'csaladi allapot': 'jeje'
};

console.log(ame.foglalkozas);
console.log(ame['nev'])