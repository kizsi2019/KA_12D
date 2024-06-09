
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
/*
const nandi = new SzemelyES6("Nándi", 1960, "Pék");
SzemelyES6.udvozlet();*/

var KatonaES5 = function(nev, szuletesiEv, foglalkozas, renfokozat, osztag){
    SzemelyES5.call(this, nev, szuletesiEv, foglalkozas)
    this.renfokozat = renfokozat;
    this.osztag = osztag;
}

KatonaES5.prototype = Object.create(SzemelyES5.prototype);

KatonaES5.prototype.rangszerzes = function(rang){
    this.renfokozat = rang;
    console.log(this.renfokozat);
}

var odonKatona = new KatonaES5("Ödon", 1970, "Pék", "közlegény", "harcosok");

odonKatona.korszamitas();
odonKatona.rangszerzes("szazados");

class KatonaES6 extends SzemelyES6{
    constructor(nev, szuletesiEv, foglalkozas, rendfokozat, osztag){
        super(nev, szuletesiEv, foglalkozas);
        this.renfokozat = rendfokozat;
        this.osztag = osztag;
    }

    rangszerzes(rang){
        this.renfokozat = rang;
        console.log(this.renfokozat);
    }
}

const nandiKatona = new KatonaES6("Nándi", 1960, "Tiszt", "harcosok osztaga");

nandiKatona.rangszerzes("szazados");
nandiKatona.korszamitas();