/*var odon = {
    nev: "ödön"
    kor: ""
} 
*/

var személy = function(nev, szuletesiev,foglalkozas)
{
    this.nev = nev;
    this.szuletesiev = szuletesiev;
    this.foglalkozas = foglalkozas;

    this.korszamitas = function(){
        console.log(2024-this.szuletesiev);
    }
};

személy.prototype.teszt ='teszt';

var odon = new személy("Ödön", 1977,"grafikus")
var erzsi = new személy("Erzsébet", 1999,"Művész")
odon.korszamitas();
erzsi.korszamitas();

console.log(személy);
console.log(odon);

console.log(odon.teszt);

