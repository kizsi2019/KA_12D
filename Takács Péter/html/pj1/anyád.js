/*const dobozES62 = 
{
    szin : 'zold',
    pozicio: 1,
    kattintsRam: () => 
    {
        document.querySelector('.green').addEventListener('click', ()=> {
            var szoveg = ' en vagyok a(z) ' + this.pozicio + ' doboz és a szinem '+ this.szin + '.'
            ',';
            alert(szoveg);
        })
    }
};

dobozES62.kattintsRam();
function Szemely(nev){
    this.nev=nev;
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

Szemely.prototype.barataimES5 = function(haverok) {
    const tomb = haverok.map(elem => '${this.nev} barátja ${elem}.' );
    console.log(tomb);
}

new Szemely('Géza').barataimES5(haverok);

var odon = ['Ödön', 50];
var nev = odon[0];
var kor = odon[1]

const dobozok = document.querySelectorAll('.rectangle');
const cimsor = document.querySelector('h1');

const htmlElemek = [címsor, ...dobozok];

array.from(htmlElemek).forEach(akutalisElem => akutalisElem.style.color = 'purple');

parosVagyParatlanES5('teszt', 1, 2, 3, 100, 5, 20);
function parosVagyParatlanES5(){
    var argumentumokTomb = Array.prototype.slice.call(arguments);
    argumentumokTomb.forEach(function(akutalisElem) {
        if(akutalisElem % 2 === 0 ){
            console.log('Paros');
        }else{
            console.log('Paratlan')
        }
    });
}
parosVagyParatlanES5('teszt', 1, 2, 3, 100, 5, 20);

function AdamsFamily(keresztNev, szuletesiEv, csaladiNev){
    csaladiNev === undefined ? csaladiNev = 'Adams' : csaladiNev = csaladiNev;
    this.keresztNev = keresztNev;
    this.szuletesiEv = szuletesiEv;
    this.csaladiNev = csaladiNev;
}

var fester = new AdamsFamily('Fester', 1940);
var mortisha = new AdamsFamily('Mortisha', 1965);
var kuzin = new AdamsFamily('Kuzin', 1800, 'Hogyishívlák'); */

const kerdes = new Map();
kerdes.set('kerdes', 'Hogy hívják a de miééért reklámban szereplő kisfiut?');
kerdes.set(1, 'ödön');
kerdes.set(2, 'ábel');
kerdes.set(3, 'nándi');
kerdes.set(4, 'mikloska');

kerdes.set('helyes', 2);

kerdes.set(true, 'Helyes válasz');
kerdes.set(false, 'Nem talált');

console.log(kerdes.get('kerdes'));
console.log(kerdes.size);   

kerdes.forEach((kulcs,ertek) => console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`));

for(let[kulcs, ertek] of kerdes.entries()){
    if(typeof(kulcs) === 'number'){
        console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`);
    }
}

const valasz = parseInt(prompt('Add meg a helyes választ! '));
console.log(kerdes.get(valasz === kerdes.get('helyes')));