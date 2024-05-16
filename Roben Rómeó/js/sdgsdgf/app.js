/*const dobozES62 = 
{
    szin : 'zold',
    pozicio: 1,
    kattintsRam: () => 
    {
        document.querySelector('.green').addEventListener('click', ()=> {
            var szoveg = 'en vagyok az apád' + this.pozicio + 'doboz és '
            + this.szin + ',';
            console.log(szoveg);
        })
    }
};

dobozES62.kattintsRam();*/


function Szemely(nev)
{
    this.nev = nev;
}

Szemely.prototype.barataimES5 = function(haverok)
{
    console.log(this.nev);
    var obj = this;
    var tomb = haverok.map(function(elem)
    {
        return obj.nev + ' baratja' + elem + ',';

    }
    
    );

    console.log(tomb);

}

var haverok = ['Áron', 'Peti', 'Roli'];
new Szemely('Bálint').barataimES5(haverok);



Szemely.prototype.barataimES6 = function(haverok)
{
const tomb = haverok.map(elem =>
    `${this.nev} baratja ${elem}.`
    );
    console.log(tomb);
}

new Szemely('Balint').barataimES6(haverok);