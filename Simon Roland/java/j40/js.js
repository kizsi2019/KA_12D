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


var odon = {
    nev : 'Ödön',
    kor: 45, 
    foglalkozas: 'csillagász',
    udvozlet: function(stilus, napszak){
        if (stilus === 'hivatalos'){
            console.log('Üdvözlöm, jó ' + napszak + ' kívánok! ' + this.nev + ' vagyok');
        }else if (stilus === 'baráti'){
            console.log('Szia, jó ' + napszak + '!');
        }
    }
}
odon.udvozlet('hivatalos', 'hajnalt');
odon.udvozlet('baráti', 'estét')

var bela = {
    nev: 'Béla',
    kor: 62,
    foglalkozas: 'portás'
}

odon.udvozlet.call(bela, 'baráti', 'estét')

odon.udvozlet.apply(bela, ['baráti', 'reggelt'])

var odonBarati = odon.udvozlet.bind(odon, 'baráti');
odonBarati('napot');
odonBarati('estét')

var belaHivatalos = odon.udvozlet.bind(bela, 'hivatalos');
var belaHivatalosReggeli = odon.udvozlet.bind(bela, 'hivatalos', 'reggelt');
belaHivatalos('estét')
belaHivatalosReggeli();
*/
var evek = [1954, 1990, 1963, 2000, 2010];
function tombMuvelet(tomb, fv){
    var eredmeny = [];
    for (var i = 0; i < tomb.length; i++){
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}
function korszamitas(elem){
    return 2024 - elem;
}

function felnott(korhatar, elem ){
    return elem >= korhatar;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(evek);
console.log(korok);

var felnottkorJapanba = tombMuvelet(korok, felnott.bind(this, 20));

console.log(felnottkorJapanba);






