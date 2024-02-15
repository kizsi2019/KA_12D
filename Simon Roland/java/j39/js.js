//Closure-ok
/*function nyugdij(ev) {
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
var nyugdijazasHUN = nyugdij(65);
var nyugdijazasIZL = nyugdij(67);
nyugdijazasHUN(2004);
nyugdijazasIZL(2004);


/////////////////////////

var szamlalo = 0;
function leptet(){
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();


var szamlalo = 0;
function leptet(){
    var szamlalo = 0;
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();


var szamlalo = 0;
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
*/

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















