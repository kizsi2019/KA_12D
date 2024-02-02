function interjukerdes(foglalkozas){
    if (foglalkozas == "tanar"){
        return function(nev){
            console.log(nev + ", meg tudná mondani milyen tárgyakat tanít?")
        }
    }
    else if (foglalkozas == "elado"){
        return function(nev){
            console.log(nev + ", hogyan kezeli egy vevő reklamációit?");
        }
    }
    else{
        return function(nev){
            console.log("Mi a foglalkozása kedves " + nev + "?")
        }
    }
}

var kerdesTanaroknak = interjukerdes("tanar");
kerdesTanaroknak("Pál");

var kerdesEladonak = interjukerdes("elado")
kerdesEladonak("Feri");
kerdesEladonak("Teri");
kerdesEladonak("Ági");

interjukerdes("tanar")("Péter");
interjukerdes("programozó")("Ödön")