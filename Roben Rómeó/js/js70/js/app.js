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
 console.log(t3);

 const dobozok = document.querySelectorAll('.rectangle');
 
 const cimsor = document.querySelector('h1');

 const htmlElemek = [cimsor, ...dobozok]

 Array.from(htmlElemek).forEach(aktualisElem => aktualisElem.style.color = 'purple');


 function parosvagyparatlan()
 {
    var argumentumokTomb = Array.prototype.slice.call(arguments);
    argumentumokTomb.forEach(function(aktualisElem)
    {
        if(aktualisElem % 2 === 0)
        {
            console.log('paros');

        }
        else
        {
            console.log('awawawawa');
        }
    });
 }


 parosvagyparatlan(1,2,3);


 function parosvagyparatlan2(...szamok)
 {
    szamok.forEach(aktualisElem => 
        {
            if (aktualisElem % 2 === 0)
            {
                console.log('paros');
            }
            
            else
            {
                console.log('paratlan');
            }
        })
 }

 parosvagyparatlan2(1,2,3);


 function parosVagyParatlanEs6(teszt,...szamok)
 {
    szamok.forEach(aktualisElem => 
        {
            if(aktualisElem % 2 === 0)
            {
                console.log('paros ');
            }
            else
            {
                console.log('fasfasdf');
            }
        });
 }

parosVagyParatlanEs6('teszt', 1,2,3,10,20,25);

function AdamsFamily(keresztNev, szuletesiEv,csaladNev)
{
    csaladNev === undefined ? csaladNev = 'Adams' : csaladNev=csaladNev;
    
    this.keresztNev = keresztNev;
    this.szuletesiEv = szuletesiEv;
    this.csaladNev = csaladNev;

}
var fester = new AdamsFamily('fester',1940);
var mortisha = new AdamsFamily('Mortisha',1965);
var kuzin = new AdamsFamily('Kuzin',1800,'Hogyishívják');


function AdamsFamily(keresztNev, szuletesiEv,csaladNev = 'Adams')
{
   
    
    this.keresztNev = keresztNev;
    this.szuletesiEv = szuletesiEv;
    this.csaladNev = csaladNev;

}
var fester = new AdamsFamily('fester',1940);
var mortisha = new AdamsFamily('Mortisha',1965);
var kuzin = new AdamsFamily('Kuzin',1800,'Hogyishívják');*/

const kerdes = new Map();
kerdes.set('kerdes' , 'Hogy is hívják a de Miééért reklámbol a kisfiut');
kerdes.set(1,'odon');
kerdes.set(2,'ábel');
kerdes.set(3,'Miklos');
kerdes.set(4,'nándi');

kerdes.set('helyes',2);

kerdes.set(true,'helyes valasz');
kerdes.set(false ,'nem talalt');

console.log(kerdes.get('kerdes'));
console.log(kerdes.size);

if(kerdes.has(3))
{
    kerdes.delete(3);
}

kerdes.clear();

kerdes.forEach
(
    (kulcs, ertek) => console.log(` kulcs: ${kulcs},ertek:${ertek}`)
);

for(let [kulcs, ertek] of kerdes.entries())
{
    if ( tyoeof(kulcs) === 'number')
    {
        console.log(`kulcs: ${kulcs},ertek:${ertek}`);
    }
}