/*const dobozES62 = {
    szin: 'zöld',
    pozicio:1,
    kattintsRam: () => {

        document.querySelector('.zold').addEventListener('click', () => {
            var szoveg = 'Én vagyok a(z) ' + this.pozicio + '. doboz és a színem ' + this.szin + '.';
            alert(szoveg);
        })
    }

};

dobozES62.kattintsRam();*/

function Szemely(nev) {
    this.nev = nev; 
}

Szemely.prototype.barataimES5 = function(haverok) {
    console.log(this.nev);
    var obj = this;
    var tomb = haverok.map(function(elem) {
        return obj.nev + ' barátja ' + elem + ',';
    });
    console.log(tomb);
}

var haverok = ['Jóska', 'Pista', 'Ödön'];
new Szemely('Géza').barataimES5(haverok);

//es6

Szemely.prototype.baratimES6 = function(haverok) {
    
    const tomb = haverok.map(elem => `${this.nev} barátja ${elem}.`
    );
    console.log(tomb);
}

new Szemely('Géza').barataimES6(haverok);

/////////////////////////////////////////////////////////////
// Destrukturálás

//es5
var odon = ['Ödön', 50];
var nev = odon[0];
var kor = odon[1];

console.log(nev2);
console.log(kor2);

const obj = {
    keresztNev: 'Ödön',
    vezetekNev: 'Bödön',
};

const { keresztNev, vezetekNev} = obj;

console.log(keresztNev);
console.log(vezetekNev);

const { keresztNev: x, vezetekNev: y } = obj;

console.log(X);
console.log(y);

function korEsNyugdij(szuletesiEv) {
    let nyugdijKorhatar = 65;
    const kor = new Date().getFullYear() - szuletesiEv;

    return [kor, nyugdijKorhatar - kor];
}

