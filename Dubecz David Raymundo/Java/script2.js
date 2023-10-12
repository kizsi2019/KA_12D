var szam;

szam = 10;

if (szam === '10') {
    console.log('egyezik');
} else {
    console.log('nem egyezik');
}

function teglalapKeruletTerulet(a, b, funkcio) {
    var eredmeny;

    if (funkcio === 'kerület') {
        erdemeny = (a + b) * 2;
    } else if (funckio === 'terület') {
        eredmeny = a * b;
    } else {
        return 'Hibás funkc';
    }
    
    return funkcio + ' = ' + eredmeny;
}

console.log(teglalapKeruletTerulet(5, 4, 'kerület'))
console.log(teglalapKeruletTerulet(5, 4, 'terület'))


var eletSzakaszok = function(nev, kor) {
    switch(true) {
        case kor < 13:
            return nev + ' gyerek';
            break;
        case kor >= 13 && kor <= 20:
            return nev + ' ifjú';
            break;
        case kor > 30 && kor <= 50:
            return nev + ' középkorú';
            break;
        default:
            return nev + ' idős';
    }

    console.log(eletSzakaszok('Kati, 12'));
    console.log(eletSzakaszok('Peti, 20'));
    console.log(eletSzakaszok('Márk, 67'));
}

var huba = {
    nev: 'Huba',
    kor: 18,
    foglalkozás: 'vezér',
    házas: true,
    barátok: ['Álmos', 'Elöd', 'Ond'],
    'családi állapot': 'nős'
};

console.log(huba.foglalkozás);
console.log(huba['név']);

var h = 'házas';
console.log(huba[h]);

console.log(huba['családi állapot']);

huba['kor'] = 40;
huba.foglalkozás = 'ács';

console.log(huba);

var tas = new Object();

tas.nev = 'Tas';
tas.kor = 17;