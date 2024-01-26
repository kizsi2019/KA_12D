var Szemely = function(nev,szuletesiEv, foglalkozás)
{
    this.nev = nev,
    this.szuletesiEv = szuletesiEv,
    this.foglalkozás = foglalkozás,

    this.korszamitas = function()
    {
        console.log(2024 - this.szuletesiEv);
    }
};
Szemely.prototype.korszamitas = function()
{
    
}
var peti = new Szemely('Peti', 1955, 'szerelem_mókus')
peti.korszamitas();

var Áron = new Szemely('Áron', 1955, 'szerelem_egér')
peti.korszamitas();

console.log(peti);