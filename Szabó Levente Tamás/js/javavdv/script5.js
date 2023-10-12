var nev1 = 'tas'
var nev2 = 'huba'
var nev3 = 'almos'

var nevek = ['tas', 'huba', 'almos'];
var korok = new Array(32, 42, 38);

console.log(korok[1]);
console.log(nevek);
console.log(nevek.length);

nevek[1] = 'tas';
console.log(nevek);

nevek[nevek.length] = 'huba';
console.log(nevek);
var huba =
{
    nev: 'huba',
    kor: 20,
    foglalkozas: 'vezér',
    hazas: true,
    baratok: ['almos'],
    'csaladi allapot': 'házas',
    szuletesiEvszamitas: function()
    {
        this.szuletesiEv = 2020 - this.kor;
    }
};

huba.szuletesiEv = huba.szuletesiEvszamitas();
console.log(huba)

console.log(almos.foglalkozas);
console.log(almos['nev'])