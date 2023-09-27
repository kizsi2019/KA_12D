/*var keresztNev = 'Pisti';
var a = 2;
console.log(keresztNev);
var vezetekNev= 'Kis';
console.log(vezetekNev);

var kor = 32;
console.log(kor)

var nagykoru = false;
console.log(nagykoru);

var magassag = 171;
console.log(magassag);
console.log(nemLetezo);
//ismétlő gyakorlatok

var keresztNev = 'Pisti';
var a = 2;

console.log(keresztNev + ' ' + kor);

var vezetekNev, felnott;
vezetekNev = 'Kovács';
//felnott = true;ű

console.log(vezetekNev + 'felnött' + felnott);

kor = 'harminc';*/

/*matematikai operátorok
var szam = 10;
var osszeg = szam + 33;
console.log(osszeg);
var kulonbseg = 100 - szam;
console.log(kulonbseg);

console.log(szam * 2);
console.log(szam/3);

//logikaiop.
var szam1 = 100;
var szam2 = 100;
var egyenlo = szam1 = szam2;
console.log(egyenlo);

//typeof
console.log(typeof szam1)

var fiuk = 23;
var lanyok = 35;

if (fiuk > lanyok) {
    console.log('a diuk vannak többen');
}
else {
    console.log('a lányok többen vannak');
}

// ---

var belaKora = 12;
var felnott = false;
if(felnott) {
    console.log('Béla már felnőt');
}
else 
{
    console.log('Béci még gyerek');
}

var film = "Gladiator";
var mufaj;

switch (film){
    case "shrek" : mufaj = "mese";
        break;
    case "terminator" : mufaj = "akcio";
        break;
    case "utazók" : mufaj = "sci-fi";
        break;
    default: 
        mufaj = " besorolatlan"
} 
console.log(mufaj);

var kor = 40;
var nev = "Béla ";

switch(true){
    case kor < 13 :
        console.log(nev + "kisfiu");
        break;
    case kor >= 13 && kor <= 20:
        console.log(nev + "tinédzser");
        break;
    case kor >= 20 && kor < 30:
        console.log(nev + "fiatal ember");
        break;
    default:
        console.log(nev + " igazi férfi");


}

var kigyok = 100;
var békák = 78;
var madarak = 198;

var tobbAHullo = kigyok + békák > madarak;
console.log(tobbAHullo);

var atlag = (kigyok+madarak+békák)/3;

console.log(atlag);

var a,b;
console.log(a);
a = b = (10+1)*2-2;

console.log(a,b);

a *= 2;
console.log(a);

a = a + 1;
a += 1;
a++;


var sutANap = false;
var joIDoVan = true;

if (sutANap != false || joIDoVan != false){
    console.log("Jó kedvem van!");
}
else {
    console.log("rossz kedvem van!")
}

var szam;

szam = 10;
/* 
if (szam || szam === 0){
    console.log("Létezik");
}
else {
    console.log("Nem létezik");
}


if (szam ==="10"){
    console.log("Egyezik");
}
else {
    console.log("Nem egyyezik")
}

function hello(nev){
    return('hello' + nev + '!');
    //console.log('hello' + nev + '!');
    //alert('hello' + nev + '!');
}
var ertek = hello('Géza');
console.log(ertek);
//console.log(hello('Géza'));
*/
function teglalapKeruleTerulet(a,b, funkcio){
    var eredmeny;

    if (funkcio === 'kerület'){
        eredmeny = (a + b) *2;
    }
    else if (funkcio === 'terület'){
        eredmeny = a*b;
    }
    else{
        return 'Hibás funkcio!';
    }
    return funkcio + '=' + eredmeny;
}
console.log(teglalapKeruleTerulet(5,4, 'kerület'));
console.log(teglalapKeruleTerulet(5,4, 'terület'));