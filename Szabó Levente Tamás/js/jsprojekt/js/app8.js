///////////////////
//spread operátor//
///////////////////

function szamok(a, b, c, d){
    return a + b + c + d;
}

var osszeg = szamok(1, 2, 3, 4);
    console.log(osszeg);

//es5
var szamTomb = [1, 2, 3, 4];
var osszeg1 = szamok.apply(null, szamTomb);
console.log(osszeg1);

//es6
const osszeg2 = szamok(...szamTomb);
console.log(osszeg2);

const t2 = [5, 6, 7, 8, 9, 10];

const t3 = [...szamTomb, ...t2];
console.log(t3);

const cimsor = document.querySelector('h1');

const htmlElemek = [cimsor, ...dobozok];

Array.from(htmlElemek).forEach(aktualisElem => aktualisElem.style.color = 'purple');
