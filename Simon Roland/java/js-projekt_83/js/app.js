// let es const
//es 5 
/*
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



//es5
var korokES5 = evek.map(function(elem){
    return 2024 - elem;
});
console.log(korokES5);

//es6 
let korokES6 = evek.map(elem=> 2024 - elem);

console.log(korokES6);

korokES6 = evek.map((elem, index) => `Kor ${index + 1}: ${2024 - elem}.`);

console.log(korokES6);

const evek = [1970,1975,1954, 2010, 1981];

korokES6 = evek.map((elem, index) => {
    const aktEv = new Date().getFullYear();
    const kor = aktEv - elem;
    return `Kor ${index + 1}: ${kor}, `;
});
console.log(korokES6)

const dobozES62 = {
    szin: 'zöld',
    pozicio: 1,
    kattintsRam: () => {
        document.querySelector('.green').addEventListener('click', () =>{
            var szoveg = 'En vagyok a(z) ' + this.pozicio + '. doboz es a szinem ' + this.szin + '.';
            alert(szoveg);
        })
    }

};

dobozES62.kattintsRam();


function Szemely(nev){
    this.nev = nev;
}

Szemely.prototype.barataimES5 = function(haverok){
    console.log(this.nev);
    var obj = this;
    var tomb = haverok.map(function(elem){
        return obj.nev + ' barátja ' + elem + '.';
    });
    console.log(tomb);
}

var haverok = ['Jóska', 'Pista', 'Ödön'];
new Szemely('Géza').barataimES5(haverok);

//es6


Szemely.prototype.barataimES6 = function(haverok){
    const tomb = haverok.map(elem => `${this.nev} barátja ${elem}.`);
    console.log(tomb);

}

new Szemely('Géza').barataimES6(haverok);

//////////////////////////////////////////////////////////////////////////////////////////////
// Destrukturalas


var odon = ['Ödön', 50];
var nev = odon[0];
var kor = odon[1];

console.log(nev);
console.log(kor);

//es 6

const [nev2, kor2] = ['Ödön', 50];
console.log(nev2);
console.log(kor2);

const obj = {
    keresztNev: 'Ödön',
    vezetekNev: 'Bödön'
};
const {keresztNev, vezetekNev} = obj;
console.log(keresztNev);
console.log(vezetekNev);

const {keresztNev: x, vezetekNev: y} = obj;
console.log(x);
console.log(y);

function korEsNyugdij(szuletesiEv) {
    let nyugdijKorhatar = 65;
    const kor = new Date().getFullYear() - szuletesiEv;
    
    return[kor, nyugdijKorhatar - kor];

}

const [kor3, nyugdij] = korEsNyugdij(1978);

console.log(kor3);
console.log(nyugdij);

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//tombok



//es5 

var dobozokTombES5 = Array.prototype.slice.call(dobozok)

dobozokTombES5.forEach(function(aktualis){aktualis.style.backgroundColor = 'orange';
});

//es6

const dobozokTombES6 = Array.from(dobozok);
dobozokTombES6.forEach(aktualis => aktualis.style.backgroundColor = 'blue');

//es5

for (var i = 0; i < dobozokTombES5.length; i++){
    if(dobozokTombES5[i].className == 'rectangle blue'){
        continue;
    }
    dobozokTombES5[i].textContent = 'Kek lettem';
}

//es6

for(const aktualis of dobozokTombES6) {
    if(aktualis.className === 'rectangle blue'){
        continue;
    }
    aktualis.textContent = 'Kek lettem xd';
}
for(const aktualis of dobozokTombES6) {
    if(aktualis.className.includes ('blue')){
        continue;
    }
    aktualis.textContent = 'Kek lettem xdd';
}

//es5 
var korok = [2, 10, 20, 17, 14]

console.log(korok);

var felnottek = korok.map(function(aktualis){
    return aktualis >=18;
});
console.log(felnottek);



console.log(felnottek.indexOf(true));

//es6
console.log(korok.findIndex(aktualis => aktualis >= 18));
console.log(korok.find(aktualis => aktualis >= 18));

////////////////////////////////////////////////////////////////////////////////////////////

// spread operator
const dobozok = document.querySelectorAll('.rectangle');

function szamok (a, b, c, d){
    return a + b + c + d;
}

var osszeg = szamok(1, 2, 3, 4);
console.log(osszeg);

//es5

var szamokTomb = [1, 2, 3, 4];
var osszeg2 = szamok.apply(null, szamokTomb);

console.log(osszeg2);

//es6

const osszeg3 = szamok(...szamokTomb);
console.log(osszeg3);

const t2 = [5, 6, 7, 8, 9, 10];

const t3 = [...szamokTomb, ...t2];
console.log(t3);

const cimsor = document.querySelector('h1');

const htmlElemek = [cimsor, ...dobozok];


Array.from(htmlElemek).forEach(aktualisElem => aktualisElem.style.color = 'purple');


/////////////////////////////////////////////////////////////////////////////////////////////////////
// rest parameter

//es5

function parosVagyparatlanES5(){
    //console.log(arguments);
    var argumentumokTomb = Array.prototype.slice.call(arguments);
    //console.log(argumentumokTomb);
    argumentumokTomb.forEach(function(aktualisElem){
        if(aktualisElem % 2 === 0){
            console.log('paros');
        }
        else{
            console.log('paratlan');
        }
    });
}


parosVagyparatlanES5(1, 2, 3);

//es6

function parosVagyparatlanES6(...szamok){
    //console.log(arguments);
    
    //console.log(argumentumokTomb);
    szamok.forEach(aktualisElem =>{
        if(aktualisElem % 2 === 0){
            console.log('paros');
        }
        else{
            console.log('paratlan');
        }
    });
}

parosVagyparatlanES6(1, 2 ,3);


function parosVagyparatlanES5(teszt){
    var argumentumokTomb = Array.prototype.slice.call(arguments, 1);
    argumentumokTomb.forEach(function(aktualisElem){
        if (aktualisElem % 2 === 0){
            console.log('paros');
        }
        else{
            console.log('paratlan');
        }
    });
}
parosVagyparatlanES5('teszt', 1, 2, 3, 100, 5, 20);

function parosVagyparatlanES6(teszt, ...szamok){
    szamok.forEach(aktualisElem => {
        if(aktualisElem % 2 === 0){
            console.log('paros');
        }
        else {
            console.log('paratlan');
        }
    })
}
parosVagyparatlanES6('teszt', 1, 2, 3, 10, 20, 25);


function AddamsFamily(keresztNev, szuletesiEv, csaladiNev){
    csaladiNev === undefined ? csaladiNev = 'Addams' : csaladiNev = csaladiNev;
    this.keresztNev = keresztNev;
    this.szuletesiEv = szuletesiEv;
    this.csaladiNev = csaladiNev;
}

var fester = new AddamsFamily('Fester', 1940);
var mortisha = new AddamsFamily('Mortisha', 1965);
var kuzin = new AddamsFamily('Kuzin', 1800, 'Hogyishívják');

//es6 

function AddamsFamily(keresztNev,szuletesiEv, csaladiNev = 'Addams'){
    this.keresztNev = keresztNev;
    this.szuletesiEv = szuletesiEv;
    this.csaladiNev = csaladiNev;
}
var fester = new AddamsFamily('Fester', 1940);
var mortisha = new AddamsFamily('Mortisha', 1965);
var kuzin = new AddamsFamily('Kuzin', 1800, 'Hogyishívják');


/////////////////////////////////////////////////////////////////////////////////
//map

const kerdes = new Map();
kerdes.set('kerdes', 'Hogy hivjak a de mieeert reklamban szereplo kisfiut? :)');
kerdes.set(1, 'Odon');
kerdes.set(2, 'Abel');
kerdes.set(3, 'Mikloska');
kerdes.set(4, 'Nandi');

kerdes.set('helyes', 2);

kerdes.set(true,'Helyes valasz');
kerdes.set(false,'Nem talalt');

console.log(kerdes.get('kerdes'));
console.log(kerdes.size);

//kerdes.delete(4);
//if (kerdes.has(3)){
//    kerdes.delete(3);
//}

//kerdes.clear();

kerdes.forEach(
(kulcs, ertek) => console.log(`kulcs: ${kulcs}, ertek:${ertek}`)
);

for (let[kulcs,ertek] of kerdes.entries()){
    if (typeof(kulcs) === 'number'){
        console.log(`kulcs: ${kulcs}, ertek: ${ertek}`);
    }
}

const valasz = parseInt(prompt('Add meg a helyes valaszt'));
console.log(kerdes.get(valasz === kerdes.get('helyes')));


///////////////////////////////////////////////////////////////////////////////////////////
//osztalyok

//es5

var SzemelyES5 = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
}

SzemelyES5.prototype.korszamitas = function(){
    var kor = new Date().getFullYear - this.szuletesiEv;
    console.log(kor);
}

var odon = new SzemelyES5('Odon', 1810, 'kisertet');

//es6

class SzemelyES6{
    constructor(nev, szuletesiEv, foglalkozas){
        this.nev = nev;
        this.szuletesiEv = szuletesiEv;
        this.foglalkozas = foglalkozas;
    }
    korszamitaS(){
        let kor = new Date().getFullYear - this.szuletesiEv;
        console.log(kor);
    }
    static udvozlet(){
        console.log('Hello');
    }
}

const tibor = new SzemelyES6('Tibor', 1960, 'eroszakos tavolbanezo, masod allasban melytengeri heggeszto ');
SzemelyES5.udvozlet();


var SzemelyES5 = function(nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
}

SzemelyES5.prototype.korszamitas = function(){
    var kor = new Date().getFullYear - this.szuletesiEv;
    console.log(kor);
}

var KatonaES5 = function(nev, szuletesiEv, foglalkozas, rendfokozat, osztag){
    SzemelyES5.call(this, nev, szuletesiEv, foglalkozas)
    this.rendfokozat = rendfokozat;
    this.osztag = osztag;
}

KatonaES5.prototype = Object.create(SzemelyES5.prototype);

KatonaES5.prototype.rangszerzes = function(rang){
    this.rendfokozat = rang;
    console.log(this.rendfokozat);
}

var odonKatona = new KatonaES5('odon', 1970, 'tjay', 'kozlegeny', 'fighters');

odonKatona.korszamitas();
odonKatona.rangszerzes('szazados');

//es6

class SzemelyES6{
    constructor(nev, szuletesiEv, foglalkozas){
        this.nev = nev;
        this.szuletesiEv = szuletesiEv;
        this.foglalkozas = foglalkozas;
    }
    korszamitaS(){
        let kor = new Date().getFullYear - this.szuletesiEv;
        console.log(kor);
    }
}
class KatonaES6 extends SzemelyES6{
    constructor(nev, szuletesiEv, foglalkozas, rendfokozat, osztag){
        super(nev, szuletesiEv, foglalkozas);
        this.rendfokozat = rendfokozat;
        this.osztag = osztag;
        
    }

    rangszerzes(rang){
        this.rendfokozat = rang;
        console.log(this.rendfokozat);
    }
}

const nandiKatona = new KatonaES6('nandi', 1960, 'tszt', 'fighters');

nandiKatona.rangszerzes('szazados');
nandiKatona.korszamitaS();


const masodik = () => {
    console.log('masodik')
};

const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
};

elso()


const masodik = () => {
    setTimeout(() => {
        console.log('Asszinkron masodik')
    }, 6000);
    
};

const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
};

elso()
*/

/////////////////////////////////////////////////////////////////////////////////////////////////
//callback hell

function receptLekerdez(){
    setTimeout(() => {
       const receptID = [676, 102, 34, 1489, 321] 
       console.log(receptID)

       setTimeout((id) => {
        const recept = {
            cim: 'gulyas leves',
            kategoria: 'levesek'
        }
        console.log(`${id}: ${recept.cim}`);

        setTimeout(kategoria => {
            const levesek = [
                {cim: 'Nyirsegi gombocleves', kategoria:'levesek'},
                {cim: 'Borsoleves', kategoria:'levesek'}
            ];
            console.log(levesek);
        }, 2000, recept.kategoria);
       }, 2000,receptID[1])
    }, 3000)
}

receptLekerdez();