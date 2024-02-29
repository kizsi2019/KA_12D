/*
var peti = {
    nev : 'Péter',
    kor: 45,
    foglalkozás:'a világ legősibbje',
    
    udvozlet: function(stilus, napszak)
    {
        if (stilus === 'hivatalos')
        {
            console.log('üdzözlöm, jó  ' + napszak + '  kívánok ' + this.nev + ' vagyok ');
        }
        else if (stilus==='barati')
        {
            console.log('szia, rossz ' + napszak + ' -ot!!! ');
        }
    }

    
}
peti.udvozlet('hivatalos','hajnalt');
peti.udvozlet('barati','estét');

var aron = 
{
    nev : 'Áron',
    kor: 16,
    foglalkozás:'alkoholista'
}

peti.udvozlet.call(aron , ' batáti', 'estét');
peti.udvozlet.apply(aron , ' batáti', 'reggelt');

var aronhivatalos = aron.udvozlet.bind('aron', 'barati');
aronBarati('napot');
aronBarati('estét');
var aronHivatalos = aron.udvozlet.bind(aron, 'hivatalos');
var aronHivatalosReggeli = aron.udvozlet.bind(aron, 'hivatalos', 'reggelt');

aronHivatalos('estét')
aronHivatalosReggeli();
*/

var evek = [1954 , 1985,2003,2010,2015,2045];

function tombMuvelet(tomb, fv)
{
    var eredmeny = [];

    for (var i = 0;i< tomb.lenght;i++)
    {
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;

}

function felnott(korhatar,elem)
{return elem>=korhatar;}

function korszamitas(elem)
{
    return 2024 - elem;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(evek);
console.log(korok);
var felnottkorJapanban=tombMuvelet(korok, felnott.bind(this, 20));

console.log(felnottkorJapanban);