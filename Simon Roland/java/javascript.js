/*var fiuk = 23;
var lanyok = 35;

if (fiuk > lanyok){
    console.log('A fiuk vannak tobben ')    
}
else{
    console.log('A lanyok vannak tobben ')
}
var belaKora = 12;
var felnott = false;

if (felnott){
    console.log('Bela mar felnott')
}
else{
    console.log('Bela meg gyerek')
}
belaKora >=18 ? console.log('Béla felnőtt') : console.log('Béla még gyerek');
var felnottVagyGyerek = belaKora >= 18 ? 'felnőtt' : 'gyerek';
console.log(felnottVagyGyerek);

var film = 'Gladiator';
var mufaj;

switch(film){
    case 'Shrek' : mufaj = 'mese';
        break;
    case 'Utazok' : mufaj = 'sci-fi';
        break;
    case 'Terminator' : mufaj = 'akció';
        break;

    default : 
        mufaj = 'besorolatlan';
}
console.log(mufaj);

var kor = 40;
var nev = 'Béla ';

switch (true) {
    case kor < 13:
        console.log(nev + 'kisfiu');
        break;
    case kor >= 13 && kor <=20:
        console.log(nev + 'tinedzser');
        break;
    case kor >=20 && kor < 30:
        console.log(nev + 'fiatalember');
        break;
    default:
        console.log(nev + 'igazi ferfi')

}

var kigyok = 100;
var bekak = 78;
var madarak = 198;

var tobbAHullo = kigyok + bekak > madarak;

var atlag = (kigyok, bekak, madarak) / 3;

console.log(atlag);

var a, b ;
console.log(a);
a = b = (10+1) * 2 - 2;

console.log(a, b);

a *= 2;
console.log(a);

a = a + 1;
a += 1;
a++;

var sutANap = true;
var joIdoVan = true;

if (sutANap && joIdoVan){
    console.log('Jó kedvem van ');
}
else{
    console.log('rossz kedvem van ');
}


if(szam || szam == 0){
    console.log('Létezik')
}
else{
    console.log('Nem létezik')
}

var szam;

szam = '10';

if (szam == '10'){
    console.log('egyezik')
}
else{
    console.log('nem egyezik ')
}


function hello(nev){
    console.log('Helló '+ nev + 'i')
}

hello('Géza')


function teglalap (a, b, funkcio){
    var eredmeny;

    if(funkcio === 'kerület'){
        eredmeny = (a + b) * 2;
    }
    else if (funkcio === 'terület'){
        eredmeny = a * b;
    }
    else{
        return 'Hibás funkció! ';
    }
    return funkcio + ' = ' + eredmeny;

}
console.log(teglalap(5, 4, 'kerület'))
console.log(teglalap(5, 4, 'terület' ))



var eletSzakasz = function(nev, kor){
    switch(true){
        case kor < 13:
            return nev + 'gyerek';
            break;
        case kor >=13 && kor <=20:
            return nev + 'tinédzser';
            break;
        case kor > 30 && kor <=50:
            return nev + 'ifju';
            break;
        default:
            return nev + 'idős'
    }
}

console.log(eletSzakasz('Kati', 12));
console.log(eletSzakasz('Peti', 20));
console.log(eletSzakasz('márk, 67'));
*/

var nev1 = 'Ond';
var nev2 = 'Kond';
var nev3 = 'Tas';

var nevek = ['Ond', 'Kond', 'Tas'];
var korok = new Array(35, 42, 38);

console.log(korok[1]);
console.log(nevek);
console.log(nevek.length);
nevek[1] = 'Huba';
console.log(nevek);
nevek[nevek.length] = 'Álmos';
console.log(nevek);
var huba = ['Huba', 38 , 'vezér', true];
console.log(huba);
huba.push(42);
console.log(huba);
huba.shift();
console.log(huba);
huba.unshift('Ifj');
console.log(huba)
huba.pop();
console.log(huba);
var szakacs = huba.indexOf('szakács') === -1 ? 'Huba nem szakács' : 'Huba szakács';
console.log(szakacs) ;
var h = 'házas';
console.log(huba[h])
console.log(huba['családi állapot'])
huba['kor'] = 40;
huba.foglalkozas ='ács';
console.log(huba);
var tas = new Object();

tas.nev = 'Tas';
tas.kor = 32;
tas ['foglalkozas'] = 'vezér';
console.log(tas);