function nyugdij(ev)
{
    var szoveg = " A Nyugdíjazásig  pegging day van hatra:  "
    return function(szuletesiev)
    {
        var datumObject = new Date();
        var aktualisEv = datumObject.getFullYear();
        var kor = aktualisEv - szuletesiev;

        console.log(szoveg +(ev-kor));
    }
}


var nyugdijazasUsa = nyugdij(66);
nyugdijazasUsa(2003);
nyugdij(66)(2003);
