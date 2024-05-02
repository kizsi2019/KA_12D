var nev5 = 'Teszt Elek';
var kor5 = 40;

nev5 = 'Kis Pista';

console.log(nev5);

function nyelvVizsga5(siker) {
    if (siker) {
        var keresztnev = "Ödön";
        var szuletesiEv = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga.');
    }
}

nyelvVizsga5(true);

const nev6 = 'Teszt Elek';
let kor6 = 40;

nev6 = 'Nimród Geci';

console.log(nev6);

function nyelvVizsga6(siker) {
    if (siker) {
        var keresztnev = "Ödön";
        const szuletesiEv = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga.');
    }
}

nyelvVizsga6(true);

let i = 9;
for (let i = 0; i < 5; i++)
{
    console.log(i); 
}

console.log(i);

var j = 9;
for (let j = 0; j < 5; j++)
{
    console.log(j);
}

console.log(j);

{
    const a = 1;
    let b = 2;
    var c =3;

}
console.log(a+b*c);


/*(function()
{
    var c =3;
    console.log(c);
}
)();


console.log(c);*/


(function()
{
    let c =3;
    console.log(c);
}
)();


console.log(c);




let vezetekNev = 'teszt';
let keresztNev = 'Elek';


const szuletesiEv =1970;

function korszamitas(ev)
{
    return 2024 - ev;
}

console.log(vezetekNev+ '  ' + keresztNev+ ',szuletett' + szuletesiEv + '-ben.Most '+ korszamitas(szuletesiEv) +'éves.');

const evek = [1970, 1975, 1954, 2010, 1980];

var korokESS = evek.map(function(elem) {
    return 2024- elem;
});

console.log(korokESS);

let korokES6 = evek.map(elem => 2024 - elem);

console.log(korokES6);

korokES6 = evek.map((elem, index) => 'Kor ${index}: $;{2024 - elem}.');

console.log(korokES6);

korokES6 = evek.map((elem, index) => {
    const aktEv = new Date().getFullYear();
    const kor = aktEv - elem;
    return 'Kor ${index}: ${kor},';
});

console.log(korokES6);
