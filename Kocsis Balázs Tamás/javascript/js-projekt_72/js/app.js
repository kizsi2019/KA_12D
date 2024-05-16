// let es const
//es 5 
var nev5 = 'Teszt Elek';
var kor5 = 40;

nev5 = "Kiss Pista";

//console.log(nev5);
//es5
function nyelvVizsga(siker){
    if (siker){
        var keresztnev = 'Ödön';
        var szuletesiEv = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}
nyelvVizsga(true);

//es6 

const nev6 = 'Teszt Elek';
let kor6 = 40;

//nev6 = 'Kiss Pista';

//console.log(nev6);

function nyelvVizsga6(siker){
    if(siker){
        var keresztnev = 'Ödön';
        const szuletesiEv = 1980;
        console.log(keresztnev + '(Születési év: ' + szuletesiEv + ') sikeres volt a vizsga' );
    }
}
//nyelvVizsga6(true);

let i = 9;
for (let i = 0; i < 5; i++){
   // console.log(i);
}

//console.log(i);

var f = 9;
for (let f = 0; f < 5; f++){
   // console.log(f);
}
//console.log(f);

{
    const a = 1;
    let b = 2;
    // var c = 3;

}


//console.log(a+b);

(function(){
    var c = 3;
    console.log(c);
})();

// console.log(c);

// stringek

let vezetekNev = 'Teszt';
let keresztNev = 'Elek';
const szuletesiEv = 1980;

function korSzam(ev) {
    return 2024 - ev;
}
//es5
console.log(vezetekNev + ' ' + keresztNev + ', szuletett ' + szuletesiEv + '-ben. Most ' + korSzam(szuletesiEv) + 'eves ');

//es6

console.log(`${vezeteknev} ${keresztNev}, szuletett ${szuletesiEv}-ben. Most ${korSzam(szuletesiEv)} eves `);

const nev = `${vezetekNev} ${keresztNev}`;

console.log(nev.startsWith('t'));

console.log(nev.endsWith('ekeee'));

console.log(nev.includes('ele'));

console.log(vezetekNev.repeat(3));

console.log(`${vezetekNev}`.repeat(3))

// nyilt fuggvenyek

const evek = [1970,1975,1954, 2010, 1981];

//es5
var korokES5 = evek.map(function(elem){
    return 2024 - elem;
});
console.log(korokES5);

let korokES6 = evek.map(elem => 2024 - elem);

console.log(korokES6);

korokES6 = evek.map((elem, index) => `Kor ${index}: ${index}: ${2024 - elem}.`);

console.log(korokES6)

korokES6 = evek.map((elem, index) => {
    const aktEv = new Date().getFullYear();
    const kor = aktEv - elem;
    return `Kor ${index}: ${kor}`;
});

console.log(korokES6)
