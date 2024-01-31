// objektum létrehozás

/*var odon = {
    nev : 'Ödön',
    szuletesiEv: '1978',
    foglalkozas: 'grafikus'
};*/

var Szemely = function(nev, szuletesiEv, foglalkozas){
    this.nev = nev;
    this.SzuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;

    /*this.korszamitas = function(){
        console.log(2024 - this.SzuletesiEv);
    }*/
};

Szemely.prototype.korszamitas = function(){
    console.log(2024 - this.SzuletesiEv);
}

Szemely.prototype.teszt = 'teszt';



var odon = new Szemely('Ödön', 1979, 'grafikus') 
odon.korszamitas();

var erzsi = new Szemely('Erzsi', 1950, 'nyugdijas')

console.log(Szemely);
console.log(odon);

console.log(odon.teszt); 