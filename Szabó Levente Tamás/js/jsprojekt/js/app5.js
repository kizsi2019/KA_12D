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

Szemely.prototype.barataimES5 = function(haverok){
    const tomb = haverok.map(elem => `${this.nev} barátja ${elem}.`
    );
    console.log(tomb);
}