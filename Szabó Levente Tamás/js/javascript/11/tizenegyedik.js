function nyugdij(ev)
{
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function(szuletesiEv)
    {
        var datumObjektum = new Date();
        var aktualisEv = datumObjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg+ (ev - kor));
    }
}
var nyugdijazasUsa = nyugdij(66);
nyugdijazasUsa(1959);
nyugdij(66)(1959);

var nyugdijazasHun = nyugdij(65);
var nyugdijazasIzl = nyugdij(67);
nyugdijazasHun(1959);
nyugdijazasIzl(1959);