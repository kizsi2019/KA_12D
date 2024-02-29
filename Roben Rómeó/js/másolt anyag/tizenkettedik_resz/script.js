// Függvény utasítások és függvény kifejezések
// function(parameterek) {}
// function eletSzakaszok(nev, kor) {}

var eletSzakaszok = function(nev, kor) {
    switch(true) {
        case kor < 13:
            return nev + " gyerek";
            break;
        case kor >= 13 && kor <= 20:
            return nev + " kamasz";
            break;
        case kor >= 20 && kor <= 30:
            return nev + " ifjúh";
            break;
        case kor >= 30 && kor <= 50:
            return nev + " középkori";
            break;
        default:
            return nev + " idős";
    }
}

console.log(eletSzakaszok("Kati", 12));
console.log(eletSzakaszok("Peti", 20));
console.log(eletSzakaszok("Márk", 67));