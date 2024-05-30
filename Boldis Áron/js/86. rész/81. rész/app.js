var SzemelyES5 = function(nev, szuletesiEv, foglalkozas){
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
}

SzemelyES5.prototype.korszamitas = function(){
    var kor = new Date().getFullYear - this.szuletesiEv;
    console.log(kor);
}

var odon = new SzemelyES5("Ödön", 1810, "Kísértet");

class SzemelyES6{
    constructor(nev, szuletesiEv, foglalkozas){
        this.nev = nev;
        this.szuletesiEv = szuletesiEv;
        this.foglalkozas = foglalkozas;
    }
    korszamitas(){
        let kor = new Date().getFullYear - this.szuletesiEv;
        console.log(kor);
    }

    static udvozlet(){
        console.log("Hello");
    }
}

const nandi = new SzemelyES6("Nándi", 1960, "Pék");
SzemelyES6.udvozlet();