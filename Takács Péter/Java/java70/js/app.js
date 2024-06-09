// let és const
//es5

/*var nev5 ='Tesz Elek';
var kor5 = 40;

nev5 = 'Takács Peti';
console.log(nev5);

//es5

function nyelvvizsga5(siker)
{
    if (siker)
    {
        var keresztnev = ' áron';
        var szuletesiEv = 2004;
        console.log(keresztnev + '(szuletesi ev:  ' + szuletesiEv+ ')sikeres a vizsga ');
    }
}

nyelvvizsga5 (true);

//es6

const nev6 ='Tesz Elek';
let kor6 = 23;

//nev6 = 'Takács Peti';

//console.log(nev6);

function nyelvvizsga6(siker)
{
    if (siker)
    {
        var keresztnev = ' áron';
        const szuletesiEv = 2004;
        console.log(keresztnev + '(szuletesi ev:  ' + szuletesiEv+ ')sikeres a vizsga ');
    }
}

nyelvvizsga6 (true);


/*let i = 9;
for ( let i =0 ; i < 5 ; i++)
{
    console.log(i);
}
console.log(i);*/


/*var i = 9;
for ( var i =0 ; i < 5 ; i++)
{
    console.log(i);
}
console.log(i);*/



/*{
    const a = 1;
    let b = 2;
    var c =3;

}
console.log(a+b*c);*/


/*(function()
{
    var c =3;
    console.log(c);
}
)();


console.log(c);*/


/*(function()
{
    let c =3;
    console.log(c);
}
)();


console.log(c);*/





let vezetekNev = 'teszt';
let keresztNev = 'Elek';


const szuletesiEv =1970;

function korszamitas(ev)
{
    return 2024 - ev;
}

console.log(vezetekNev+ '  ' + keresztNev+ ',szuletett' + szuletesiEv + '-ben.Most '+ korszamitas(szuletesiEv) +'éves.');
console.log('${vezetekNev} ${keresztNev} , szuletett ${korszamitas(szuletesiEv)} éves');

const nev = '${vezetekNev} ${keresztNev}';
console.log(nev.startsWith('T'));
console.log(nev.endsWith('ek'));
console.log(nev.includes('ele'));
console.log(vezetekNev.repeat('3'));
console.log('${keresztNev}'.repeat('3'));
 
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