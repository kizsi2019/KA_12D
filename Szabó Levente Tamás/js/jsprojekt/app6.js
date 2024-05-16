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

var haverok = ['Pista', 'Jóska', 'Odon'];
new Szemely('Géza').barataimES5(haverok);

////////////////////////////////
//////// Destruktúrálás ////////
////////////////////////////////

//es5
var odon = ['Odon', 50];
var nev = odon[0];
var kor = odon[1];

console.log(nev);
console.log(kor);

//es6
const [nev2, kor2] = ['Odon', 50];
console.log(nev2);
console.log(kor2);