/*
function jatek(){
    var pont = Math.random() * 10
    console.log(pont >= 5);
}

jatek(){
    (function(){
        var pont = Math.random() * 10;
        console.log(pont >= 5);
    }
)();

(function(teszt){
    var pont = Math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
})('Hello')

function nyugdij(ev) {
    var szoveg = "A nyugdíjazásig hátralévő évek száma: "
    return function(szuletesiev) {
        var dateobj = new Date();
        var currentyear = dateobj.getFullYear();
        var kor = currentyear - szuletesiev;
        console.log(szoveg + (ev - kor));
    }
}

var nyugdijusa = nyugdij(66);
nyugdijusa(1959);
nyugdij(66)(1959);

var nyugdijhu = nyugdij(65);
var nyugdijiz = nyugdij(67);
nyugdijhu(2004);
nyugdijiz(2004);


var szamlalo = 0;

function leptet() {
    szamlalo++;
    console.log(szamlalo);
}

leptet();
leptet();
leptet();




function leptet() {
    var szamlalo = 0;
    szamlalo++;
    console.log(szamlalo);
}

leptet();
leptet();
leptet();
*/

function leptet() {
    var szamlalo = 0;
    return function(){
        szamlalo++;
        console.log(szamlalo);
    }
    
}

var hozaad = leptet();
hozaad();
hozaad();
hozaad();

var leptet = (
    function() {
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

