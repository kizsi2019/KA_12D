// Closures - Lezárások/Bezárások

/*
function nyugdij(ev) {
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function(szuletesiEv) {
        var datumObjektum = new Date();
        var aktualisEv = datumObjektum.getFullYear();
        var kor = aktualisEv - szuletesiEv;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdijazasUSA = nyugdij(66);
nyugdijazasUSA(2003);

/* Closure összefoglaló
Egy belső függvény mindig képes hozzáférni az őt tartalmazó külső függvény paramétereihez
és változóihoz, még azután is, hogy a külső függvény befejezte futását.


var nyugdijazasHUN = nyugdij(65);
var nyugdijazasIZL = nyugdij(67);
nyugdijazasHUN(2003);
nyugdijazasIZL(2003);


//////////
var szamlalo = 0;

function leptet() {
    szamlalo++;
    console.log(szamlalo);
}

leptet();
leptet();
leptet();

var szamlalo = 0;

function leptet() {
    var szamlalo = 0;
    szamlalo++;
    console.log(szamlalo);
}

leptet();
leptet();
leptet();

var szamlalo = 0;

function leptet() {
    var szamlalo = 0;

    return function() {
        szamlalo++;
        console.log(szamlalo);
    }
}

var hozzaad = leptet();
hozzaad();
hozzaad();
hozzaad();
*/


var leptet = (
    function() {
        var szamlalo = 0;
        
        return function() {
            szamlalo++;
            console.log(szamlalo);
        }
    }
)();

leptet();
leptet();
leptet();