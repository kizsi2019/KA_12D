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
a++;*/

var sutANap = true;
var joIdoVan = true;

if (sutANap && joIdoVan){
    console.log('Jó kedvem van ');
}
else{
    console.log('rossz kedvem van ');
}