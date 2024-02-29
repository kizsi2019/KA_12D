// Ternáris operátor és a Switch szerkezet

var belaKora = 54;
var felnott = false;

belaKora >= 18 ? console.log("Béla férfi") : console.log("Béla kisperec");

/*
var felnottVagyGyerek = belaKora >= 18 ? "felnőtt" : "kisperec";
console.log(felnottVagyGyerek);
*/

var film = "Shrek";
var mufaj;

switch (film) {
    case "Shrek" : mufaj = "mese";
        break;
    case "Terminator" : mufaj = "akció";
        break;
    case "Utazók" : mufaj = "sci-fi";
        break;
    default:
        mufaj = "besorolatlan";
}

console.log(mufaj);

var kor = 50;
var nev = "Mocskos Ferenc";

switch(true) {
    case kor < 13 :
        console.log(nev + " Kisgyökér");
        break;
    case kor >= 13 && kor <= 20 :
        console.log(nev + " Tiniédzser");
        break;
    case kor >= 20 && kor < 30 :
        console.log(nev + " Fiatal grinder");
        break;
    default:
        console.log(nev + " Isten7");
}