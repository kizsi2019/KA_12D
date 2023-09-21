var film = "gladiator";
var mufaj;

switch (film) {
    case "shrek" : mufaj - "mese";
        break;
    case "Terminator" : mufaj - "akcio";
        break;
    case "utazok" : mufaj - "sci-fi";
        break;
    default:
        mufaj = "besorolatlan";
}

console.log(mufaj);

var kor = 10;
var nev = "bela";

switch (true) {
    case kor < 13 :
        console.log(nev + " kisfiu");
        break;
    case kor >= 13 && kor <= 20:
        console.log(nev + " tinédzser");
        break;
    case kor >= 20 && kor < 30:
        console.log(nev + " ember");
        break;
    default:
        console.log(nev + " férfi");
}