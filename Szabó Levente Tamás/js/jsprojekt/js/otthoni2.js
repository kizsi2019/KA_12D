//ES5
var SzemelyES5 = function(nev, szuletesiEv, foglalkozas){
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
}

SzemelyES5.prototype.korSzamitas = function(){
    var kor = new Date().getFullYear - this.szuletesiEv;
    console.log(kor);
}

var KatonaES5 = function(nev, szuletesiEv, foglalkozas, rendfokozat, osztag){
    SzemelyES5.call(this, nev, szuletesiEv, foglalkozas);
    this.rendfokozat = rendfokozat;
    this.osztag.osztag;
}

KatonaES5.prototype = Object.create(SzemelyES5.prototype);

KatonaES5.prototype.rangSzerzes = function(rang){
this.rendfokozat = rang;
console.log(this.rendfokozat);
}

var odonkatona= new KatonaES5('Ödön', 1970, 'közlegény', 'harcosok');
odonkatona.korSzamitas();

//ES6

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

class KatonaES6 extends SzemelyES6{
    constructor(nev, szuletesiEv, foglalkozas, rendfokozat, osztag){
        super(nev, szuletesiEv, foglalkozas);
        this.rendfokozat = rendfokozat;
        this.osztag = osztag;
    }
    rangSzerzes(rang){
        this.rendfokozat = rang;
        console.log(this.rangfokozat)
    }
}

const andi = new KatonaES6('Andi', 1960, 'tanár', 'tiszt', 'harcosok');
andikatona.rangSzerzes('Százados')
andikatona.korSzamitas();