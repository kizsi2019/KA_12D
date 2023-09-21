var fiuk = 23;
var lanyok = 35;

if (fiuk > lanyok) {
    console.log('A fiúk vannak többen')
} else {
    console.log('A lányok vannak többen')
}

var belaKora = 12;
var felnott = false;

if (felnott) {
    console.log('Béla már felnőtt');
} else {
    console.log('Béci még gyerek');
}

belaKora >=18 ? console.log('Béla felnőtt') : console.log('Béla gyerek');

var felnottVagyGyerek = belaKora >= 18 ? 'felnőtt' : 'gyerek';
console.log(felnottVagyGyerek);

var film = 'Shrek';
var mufaj;

switch (film) {
    case 'Shrek' : mufaj = 'mese;'
        break;
    case 'Terminator' : mufaj = 'akció';
        break;
    case 'Utazók' : mufaj = 'sci-fi';
        break;
    default :
        mufaj = 'besorolatlan';
}

console.log(mufaj);

var kor = 10;
var nev = "Mocskos Ferenc";

switch(true) {
    case kor < 13 :
        console.log(nev + " Kisgyökér");
        break;
    case kor >= 13 && kor <= 20 :
        console.log(nev + " Tinédzser")
        break;
    case kor >= 20 && kor < 30 :
        console.log(nev + " Fiatal grinder")
        break;
    default:
        console.log(nev + " Isten7");
}

var kigyo = 100;
var bekak = 78;
var madarak = 198;

var tobbAHullo = kigyok + bekak > madarak;
console.log(tobbAHullo);

var atlag = (kigyok + bekak + madarak) /3;

console.log(atlag);

var a, b;
console.log(a);
a = b = (10 + 1) * 2 - 2;
console.log(a, b);

a *=2;
console.log(a);

a = a + 1;
a += 1;
a++;

var sutANap = true;
var joIdoVan = false;

if (sutANap || joIdoVan) {
    console.log("Jó kedvem van")
} else {
    console.log("Rossz kedvem van")
}