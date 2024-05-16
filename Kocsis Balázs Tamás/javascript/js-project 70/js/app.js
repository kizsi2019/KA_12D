// let es const
//es5

var nev5 = 'Teszt Elek';
var kor5 = 40;

nev5 = 'Kiss Pista';

// console.log(nev5)
// es5

function nyelvVizsga5(siker){
    if(siker){
        var keresztNev = 'Ödön';
        var szuletesiEv = 1980;
        console.log(keresztNev + '(szuletesi ev: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}
nyelvVizsga5(true);

// es6

const nev6 = 'Teszt Elek'
let kor6 = 40;

// nev6 = 'Kiss Pista'; hibat dob

//console.log(nev6);

function nyelvVizsga6(siker){
    if(siker){
        var keresztNev = 'Ödön';
        const szuletesiEv = 1980;
        console.log(keresztNev + '(szuletesi ev: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}
nyelvVizsga6(true);

/*let i = 9;
for (let i = 0; i < 5; i++){
    console.log(i);
}

console.log(i);*/

var i = 9;
for (var i = 0; i < 5; i++){
    console.log(i);
}

console.log(i);

//////////////////////////////////////////////////////////////////////////////////////////////
// blokkok es iife
// es6
{
    const a = 1;
    let b = 2;
    //var c = 3;
    
    console.log(a + b);
}

// es5
(function(){
    var c = 3;
    console.log(c);
})();

//console.log(c);

(function(){
    let c = 3;
    console.log(c);
})();

//console.log(c);

//stringek

let vezetekNev = 'Teszt';
let keresztNev = 'Elek';
const szuletesiEv = 1980;

function korSzam(ev){
    return 2024 - ev;
}

console.log(vezetekNev + ' ' + 'született ' + szuletesiEv + '-ban/-ben. Most ' + korSzam(szuletesiEv) + 'eves.');

//es6

console.log(`${vezetekNev} ${keresztNev}, szuletett ${szuletesiEv} -ben. Most ${korSzamitas(szuletesiEv)} eves.`);

const nev = `${vezetekNev} ${keresztNev}`;

console.log(nev.startsWith('T'));
console.log(nev.endsWith('ekeeeeee'));
console.log(nev.includes('szt E'));
console.log(vezetekNev.repeat(2));
console.log(`${vezetekNev}`.repeat(3));