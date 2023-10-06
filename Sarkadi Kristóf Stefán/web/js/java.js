var fiuk = 23;
var lanyok = 35;

if (fiuk > lanyok) {
    console.log('A fiúk vannak többen.')
} else {
    console.log('A lányok vannak többen.')
}

// ---

var belaKora = 12;
var felnott = false;

if (felnott) {
    console.log('Béla már felőtt.')
} else {
    console.log('Béci még gyerek.')
}

belaKora >=18 ? console.log('Béla felnőtt') : console.log('Béla gyerek');

var kor = 10;
var nev = 'Bela';

switch (true) {
    case kor < 13:
        console.log(nev + ' kisfú')
        break;
    case kor >= 13 && <= 20:
        console.log(nev + ' tinédzser');
        break;
    case kor >= 20 && <30:
        console.log(nev + ' fiatalamber');
        break;
    default:
        console.log(nev + ' igazi férfi');
}