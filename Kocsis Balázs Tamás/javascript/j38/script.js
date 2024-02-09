function nyugdij(ev){
    var szoveg = "A nyugdíjazásig hátralévő évek: "
    return function(szuletesiEv){
        var datumObjektum = new Date();
        var aktualisEv = datumObjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdijazasUSA = nyugdij(66);
nyugdijazasUSA(2004);
nyugdij(66)(1959);