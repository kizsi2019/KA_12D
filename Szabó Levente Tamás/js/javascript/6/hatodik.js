var odon =
{
    nev: 'Ödön',
    szuletesiEv: 1979,
    foglalkozas: 'grafikus'
}
var Szemely = function(nev, szuletesiEv, foglalkozas)
{
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;
    this.korszamitas = function()
    {
        console.log(2024 - this.szuletesiEv);
    }
};
Szemely.prototype.korszamitas = function()
{
    console.log(2024 - this.szuletesiEv);
}
Szemely.prototype.teszt = 'teszt';
var odon = new Szemely('Ödön', 1979, 'grafikus')
odon.korszamitas();
var eszti = new Szemely('Eszti', 1950, 'nyugdíjas')
odon.korszamitas();
console.log(Szemely);
console.log(odon);
console.log(odon.teszt);