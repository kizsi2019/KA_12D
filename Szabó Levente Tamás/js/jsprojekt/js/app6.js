function Szemely(nev) {
    this.nev = nev;
}

Szemely.prototype.barataimES5 = function(haverok) {
    console.log(this.nev);
    var obj = this;
    var tomb = haverok.map(function(elem) {
        return obj.nev + ' barátja ' + elem + '.';
    });
    console.log(tomb)
}

var haverok = ['Pista', 'Jóska', 'Ödön'];
new Szemely('Géza').barataimES5(haverok);

////////////////////////////////
//////// Destruktúrálás ////////
////////////////////////////////

//es5
var odon = ['Ödön', 50];
var nev = odon[0];
var kor = odon[1];

console.log(nev);
console.log(kor);

//es6
const [nev2, kor2] = ['Ödön', 50];
console.log(nev2);
console.log(kor2);

const obj = {
    keresztNev: 'Ödön',
    vezetekNev: 'Bödön'
};

const { keresztNev, vezetekNev } = obj;

console.log(keresztNev);
console.log(vezetekNev);

const { keresztNev: x, vezetekNev: y } = obj;

console.log(x);
console.log(y);

function korEsNyugdij(szuletesiEv) {
    let nyugdijKorhatar = 65;
    const kor = new Date().getFullYear - szuletesiEv;
    return[kor, nyugdijKorhatar - kor];
}

const [kor3, nyugdij] = korEsNyugdij(1978);
console.log(kor3);