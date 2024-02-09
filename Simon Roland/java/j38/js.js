//Closure-ok
function nyugdij(ev) {
    var szoveg = "A nyugdijazasig hatralevo evek szama: "
    return function(szuletesiEv){
        var datumObjektum = new Date();
        var aktualisEv = datumObjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdijazasUSA = nyugdij(66);
nyugdijazasUSA(2004);
nyugdij(66)(2004)