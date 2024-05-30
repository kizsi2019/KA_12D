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


let i = 9;
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
console.log(i);



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


console.log(c);


(function()
{
    let c =3;
    console.log(c);
}
)();


console.log(c);
const dobozok = document.querySelectorAll('.rectangle');


function szamok(a,b,c,d)
{
    return a+b+c+d;
}
 var osszeg = szamok (1,2,3,4);
 console.log(osszeg);

 var szamokTomb = [1,2,3,4];
 var osszeg2 = szamok.apply(null, szamokTomb);

 console.log (osszeg2);

 var szamokTomb = [1,2,3,4];
 const osszeg3 = szamok(...szamokTomb);
 console.log(osszeg3);

 const t2 = [5,6,7,8,9,10];

 const t3 = [...szamokTomb,...t3];
 console.log(t3);*/

 const dobozok = document.querySelectorAll('.rectangle');
 
 const cimsor = document.querySelector('h1');

 const htmlElemek = [cimsor, ...dobozok]

 Array.from(htmlElemek).forEach(aktualisElem => aktualisElem.style.color = 'purple');