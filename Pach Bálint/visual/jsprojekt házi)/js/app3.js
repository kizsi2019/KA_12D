//1//
//let const
//es5
var nev5 = 'guba';
var kor = '1000';
nev5 = 'shork';
console.log(nev5)

function nyelvVizsga5(siker){
    if (siker){
        var keresztnev = 'guba';
        var szuletesEv = 1;
        console.log(keresztnev + ' (születési év: ' + szuletesEv + ') sikeres vizsga volt');
    }
}

nyelvVizsga5(true);
//es6
const nev6 = 'guba';
let kor6 = '1000';
//nev6 = 'neves'; //hibás
//console.log(nev6)

var i = 9;
for (var i = 0; i < 5; i++){
    console.log(i);
}
console.log(i);
//2//
////////////////////////////////
/////////Blokkok és IFE/////////
////////////////////////////////
{
    const a = 1;
    let b = 2;
    var c = 3;
}
//console.log(a + b);

(function(){
    var c = 3;
}());
console.log(c);

if (c + 1 == 4){
    console.log("gubba");
}
else{
    console.log("nem gubba");
}
//3//
let vezeteknev = 'shork';
let keresztnev = 'guba'
const szuletesEv = 1;

function korSzamitas(ev){
    return 2024 - ev;
}
//es5
console.log(vezeteknev + ' ' + keresztnev + ', született ' + szuletesEv + ' -ben, most ' + korSzamitas(szuletesEv) + ' éves.');
//es6
console.log(`${vezeteknev}, ${keresztnev}, született ${szuletesEv}-ben, most ${korSzamitas(szuletesEv)} éves.`);
const nev = `${vezeteknev} ${keresztnev}`;
console.log(nev.startsWith("s"));
console.log(nev.endsWith("ba"));
console.log(nev.includes("gub"));
console.log(vezeteknev.repeat(3));
console.log(keresztnev.repeat(3));

////////////////////////////////
///////// Nyíl függvény ////////
////////////////////////////////

const evek = [1, 1970, 1980, 1990, 2000];

var korokES5 = evek.map(function(elem){
    return 2024 - elem;
});
console.log(korokES5);

let korokES6 = evek.map(elem => 2024 - elem);
console.log(korokES6);

kororkES6 = evek.map((elem, index)=>{
    const aktEv = new Date().getFullYear();
    const kor = aktEv - elem;
    return `kor ${index}: ${kor},`;
});
console.log(korokES6);

const dobozES62 = {
    szin: 'zöld',
    pozicio: 1,
    kattintsRam: () => {
        document.querySelector('.zold').addEventListener('click', () => {
            var szoveg = 'Én vagyok a(z) ' + this.pozicio + '. doboz és a színem ' + this.szin + '.';
            alert(szoveg);
        })
    }
};

dobozES62.kattintsRam();