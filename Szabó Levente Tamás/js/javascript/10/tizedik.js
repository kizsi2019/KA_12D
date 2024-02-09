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
/*Belső függvény mindig hozzá tud férni az őt tartalmazó külső függvény paramétereihez és válzozóihoz, még az után is, hogy a külső függvény befejezte a futását.*/