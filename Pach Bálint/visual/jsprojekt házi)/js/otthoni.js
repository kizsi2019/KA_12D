//Osztályok//
var SzemelyES5 = function(nev, szuletesiEv, foglalkozas){
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
}

SzemelyES5.prototype.korSzamitas = function(){
    var kor = new Date().getFullYear - this.szuletesiEv;
    console.log(kor);
}

var odon = new SzemelyES5('Ödön', 1810,'kisértet');

class SzemelyES6 {
    constructor (nev, szuletesiEv, foglalkozas){
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
    }
    korSzamitas(){
        let kor = new Date().getFullYear - this.szuletesiEv;
        console.log(kor)
    }
    static udvozlet(){
        console.log('helo');
    }
}
const andi = new SzemelyES6('Andi', 1970, 'pék')
SzemelyES6.udvozlet();