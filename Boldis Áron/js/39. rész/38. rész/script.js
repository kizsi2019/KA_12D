//Closure-ök

/* function nyugdij(év){
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
Egy belső függvény mindig képes hozzáférni az ő

var nyugdijazasIZL = nyugdij(67);
nyugdijazasIZL(1959);

var szamlalo = 0;
 */

function leptet(){
    var szamlalo = 0;

    return function(){
        szamlalo++;
        console.log(szamlalo);
    }
}
var hozzaad = leptet();
hozzaad();
hozzaad();
hozzaad();

var leptet = (
    function(){
        var szamlalo = 0;

        return function(){
            szamlalo++;
            console.log(szamlalo);
        }
    }
)();

leptet();
leptet();
leptet();