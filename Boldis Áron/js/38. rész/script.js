//Closure-ök

function nyugdij(év){
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function (szuletesiEv) {
        var datumObjektum = new Date();
        var aktualisEv = datumObjektum = new Date();
        var aktualisEv = datumObjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdijazasUSA = nyugdij(66);
nyugdijazasUSA(1959);
nyugdij(66)(1959);

/* Closure osszefoglaló
Egy belső függvény mindig képes hozzáférni az ő/*