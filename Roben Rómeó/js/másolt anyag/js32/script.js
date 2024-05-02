//objektum letrehozasa
/*
var odon = {
    nev: 'Odon',
    szuletesiev: '1978',
    foglalkozas: 'grafikus',
};*/

var Szemely = function(nev, szuletesiev, foglalkozas){
    this.nev = nev;
    this.szuletesiev = szuletesiev;
    this.foglalkozas = foglalkozas;
this.korszamitas = function(){
    console.log(2024 - this.szuletesiev)
}
};
Szemely.prototype.korszamitas = function(){
    console.log(2024 - this.szuletesiev);
}
Szemely.prototype.teszt = 'teszt';


var odon = new Szemely('Odon', 1979, 'grafikus')
odon.korszamitas();

var erzsi = new  Szemely('Erzsi', 1950, 'nyugdijas')
erzsi.korszamitas();
console.log(Szemely);
console.log(odon);
console.log(odon.teszt);