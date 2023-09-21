var fiuk = 23;
var lanyok = 35;

if (fiuk > lanyok) {
    console.log('A fiúk vannak többen. ');
} else {
    console.log('A lányok vannak többen. ')
}



var belaKora = 12;
var  felnott = false;

if (felnott) {
    console.log('Béla már felnőtt. ');
} else {
    console.log('Béci még gyerek. ');
}

belaKora >=18 ? console.log('Béla felnőtt') : console.log('Béla gyerek');

var film = "Gladiator";
var mufaj;

switch (film){
    case "shrek" : mufaj = "mese";
        break;
    case "terminator" : mufaj = "akcio";
        break;
    case "utazók" : mufaj = "sci-fi";
        break;
    default:
        mufaj = " besorolatlan"
}
console.log(mufaj);

var kor = 40;
var nev = "Béla ";

switch(true){
    case kor < 13 :
        console.log(nev + "kisfiu");
        break;
    case kor >= 13 && kor <= 20:
        console.log(nev + "tinédzser");
        break;
    case kor >= 20 && kor < 30:
        console.log(nev + "fiatal ember");
        break;
    default:
        console.log(nev + " igazi férfi");

}
