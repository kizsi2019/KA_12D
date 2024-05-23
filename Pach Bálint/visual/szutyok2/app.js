const dobozok = document.querySelectorAll('.rectangle');
//es5

var dobozokTombES5 = Array.prototype.slice.call(dobozok)

    dobozokTombES5.forEach(function(aktualis){
        aktualis.style.backgroundColor = 'orange';
    });

//es6

const dobozokTombES6 = Array.from(dobozok);
dobozokTombES6.forEach(aktualis => aktualis.style.backgroundColor = 'blue');

//es5

for (var i = 0; i < dobozokTombES5.length; i++){
    if (dobozokTombES5[i].className === 'rectangle blue'){
        continue;
    }
    dobozokTombES5[i].textContent = 'Kék lettem';
}

//es6

for (const aktualis of dobozokTombES6){
    if (aktualis.className.includes('blue')){
        continue;
    }
    aktualis.textContent = 'Kék lettem';
}


//es5

var korok = [2, 10, 20, 17, 14]
console.log(korok);

var felnottek = korok.map(function(aktualis){
    return aktualis >= 18;
});

console.log(felnottek);

console.log(felnottek.indexOf(true));

//es6
console.log(korok.findIndex(aktualis => aktualis >= 18));
console.log(korok.find(aktualis => aktualis >= 18));

////////////////////////////////////////////////////////////////
// let, const

// ES5
// Általánosságban a változók előtt csak "var" van, ezek értékei bármikor megváltoztathatóak.
// Függvényen belül létrehozott "var" változó csak a függvényen belül érhető el!

/*
var nev5 = 'Vicc Elek';
var kor5 = 40;
nev5 = 'Abbanapillanatban Debrüi'
console.log(nev5);
// console.log(nev5);
function nyelvVizsga5(siker) {
    if (siker) {
@@ -19,6 +24,8 @@ nyelvVizsga5(true);
// ES6
// Két fő változó van, a "const" olyan változó aminek értéke folyamatos és nem változtatható meg, a "let" pedig olyan mint a "var", ezek változhatnak.
// Függvényen belül létrehozott "const" vagy "let" változó blokk szinten érhetők el (kapcsos zárójelek közt lévő egység).
const nev6 = 'Fing Ottam';
let kor6 = 40;
@@ -28,20 +35,22 @@ let kor6 = 40;
function nyelvVizsga6(siker) {
    if (siker) {
        var keresztnev = 'Trottyos';
        let keresztnev = 'Trottyos';
        const szuletesiEv = 1985;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}
nyelvVizsga6(true);
// Itt az "i" két különböző változó, mivel a "let" blokk szintű, két különböző világ.
let i = 9;
for (let i = 0; i < 5; i++) {
    console.log(i);
}
console.log(i);
// A két "i" ugyanaz a változó, csak az értékét írtuk át.
var i = 9;
for (var i = 0; i < 5; i++) {
    console.log(i);
@@ -51,22 +60,26 @@ console.log(i);
////////////////////////////////////////////////////////////////
// Blokkok és IIFE
// ES6
// Hibát kapunk, mivel a változók csak blokkon belül érhetők el, így nem tudjuk őket külön kiírni.
{
    const a = 1;
    let b = 2;
    // var c = 3;
    var c = 3; //Blokkon belül is lehet "var" változó, de függvény szintű láthatósággal rendelkezik.
}
// console.log(a + b);
// ES5
// 
(function() {
    let c = 3;
    console.log(c);
    var c = 3;
    // console.log(c);
})();
console.log(c);
console.log(c); //Nem a függvényen belüli "c"-t fogja kiírni, hanem a blokkban lévőt.
////////////////////////////////////////////////////////////////
@@ -82,9 +95,13 @@ function korszamitas(ev) {
}
// ES5
// Átlagos kiíratás, nehezebb kiírni a sok aposztrófok miatt.
console.log(vezetekNev + ' ' + keresztNev + ' ' + szuletesiEv + '-ben született. Most ' + korszamitas(szuletesiEv) + ' éves.');
// ES6
// Hatékonyabb kiíratás, backTick-ek (``) közt kell megadni a szöveget, változókat. (Template literal)
console.log(`${vezetekNev} ${keresztNev}, született ${szuletesiEv}-ben. Most ${korszamitas(szuletesiEv)} éves.`);
const nev = `${vezetekNev} ${keresztNev}`;
@@ -102,18 +119,23 @@ console.log(`${vezetekNev} `.repeat(3));
const evek = [1970, 1975, 1954, 2010, 1981];
// ES5
// map -> Metódus, amivel végigjárjuk a tömböt.
var korokES5 = evek.map(function(elem) {
    return 2024 - elem;
});
console.log(korokES5);
// ES6
// Nyíl függvény -> paraméter (több paraméter esetén zárójel kell) => return érték.
let korokES6 = evek.map(elem => 2024 - elem);
console.log(korokES6);
korokES6 = evek.map((elem, index) => `Kor ${index}: ${2024 - elem}.`);
console.log(korokES6);
// Több utasítás esetén a nyíl függvényben kapcsos zárojeleket használunk.
korokES6 = evek.map((elem, index) => {
    const aktEv = new Date().getFullYear();
    const kor = aktEv - elem;
@@ -131,7 +153,7 @@ var dobozES5 = {
    szin: 'zöld',
    pozicio: 1,
    kattintsRam: function() {
        var objektum = this;
        var objektum = this; // Ezzel tudunk a "dobozES5" blokkon belüli dolgokra hivatkozni.
        document.querySelector('.zold').addEventListener('click', function() {
            var szoveg = 'Én vagyok az ' + objektum.pozicio + '. doboz, a színem ' + objektum.szin + '.';
            alert(szoveg);
@@ -141,6 +163,8 @@ var dobozES5 = {
// dobozES5.kattintsRam();
// ES6
// Itt már nem kell külön változó az objektumra, az egész kódrész egy blokkban van, így elég a "this".
const dobozES6 = {
    szin: 'zöld',
    pozicio: 1,
@@ -153,6 +177,7 @@ const dobozES6 = {
}
dobozES6.kattintsRam();
// ES5
function Szemely(nev) {
    this.nev = nev; 

    //es5
    var szamokTomb = [1, 2, 3, 4];
    var osszeg2 = szamok.apply(null, szamokTomb);

    console.log(osszeg2);

    //es6
    const osszeg3 = szamok(...szamokTomb);
    console.log(osszeg3);

    const t2 = [...szamokTomb, ...t2];
    console.log(t3); 

    const cimsor = document.querySelector('h1');

    const htmlElemek = [cimsor, ...dobozok];

    Array.from(htmlElemek).forEach(aktualisElem => aktualisElem.style.color = 'purple'); */

    //es5

    function parosVagyParatlanES5() {
        //console.log(arguments);
        var argumentumokTomb = Array.prototype.slice.call(arguments);
        //console.log(argumentumokTomb);
        argumentumokTomb.forEach(function(aktualisElem) {
            if (aktualisElem % 2 === 0) {
                console.log('Paros');
            } else {
                console.log('Paratlan');
            }
        });
    }

    parosVagyParatlanES5('teszt', 1, 2, 3, 100, 5, 20);

    function parosVagyParatlanES6(teszt, ...szamok) {
        //console.log(szamok);
        szamok.forEach(aktualisElem => {
            if (aktualisElem % 2 ===0) {
                console.log('Paros');
            } else {
                console.log('Paratlan');
            }
        })
    }

    parosVagyParatlanES6('teszt', 1, 2, 3, 10, 20, 25);

    //es5

    function AdamsFamily(keresztNev, szuletesiEv, csaladiNev) {
        csaladiNev === undefined ? csaladiNev = 'Adams' : csaladiNev = csaladiNev;
        this.keresztNev = keresztNev;
        this.szuletesiEv = szuletesiEv;
        this.csaladiNev = csaladiNev;

    }

    var fester = new AdamsFamily('Fester', 1940);
    var mortisha = new AdamsFamily('Mortisha', 1965);
    var kuzin = new AdamsFamily('Kuzin', 1800, 'Hogyishívják');

    //es6
    function AdamsFamily(keresztNev, szuletesiEv, csaladiNev = 'Adams')
    {
        this.keresztNev = keresztNev;
        this.szuletesiEv = szuletesiEv;
        this.csaladiNev = csaladiNev;
    }
    var fester = new AdamsFamily('Fester', 1940);
    var mortisha = new AdamsFamily('Mortisha', 1965);
    var kuzin = new AdamsFamily('Kuzin', 1800, 'Hogyishívják');

    ///////////////////////////////////////////////////////////////////////////////// Map

    const kerdes = new Map ();
    kerdes.set('kerdes', 'Hogy hívják a de miééért reklámban szereplő kisfiút?');
    kerdes.set(1, 'Ödön');
    kerdes.set(2, 'Ábel');
    kerdes.set(3, 'Miklóska');
    kerdes.set(4, 'Nándi');

    kerdes.set('helyes', 2);

    kerdes.set(true, 'Helyes válasz');
    kerdes.set(false, 'Nem talált');

    console.log(kerdes.get('kerdes'));
    console.log(kerdes.size);

    kerdes.delete(4);

    if (kerdes.has(3)) {
        kerdes.delete(3);
    }

    kerdes.clear();

    kerdes.forEach(
        (kulcs, ertek) => console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`));
    
    for (let [kulcs, ertek] of kerdes.entries()) {
        if (typeof(kulcs) === 'number') {
            console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`); 
        }

    }



