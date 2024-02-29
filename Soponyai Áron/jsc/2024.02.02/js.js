var evek = [1954, 1990, 1963, 2000, 2010];

function tombmuvelet(tomb, fv){
    var eredmeny = [];

    for (var i = 0; i < tomb.length; i++)
    {
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}

function korszamitas(elem)
{
    return 2024 - elem;
}

function felnott(elem){
    return elem >= 18;
}

var korok = tombmuvelet(evek, korszamitas);
console.log(korok);

var felnottek = tombmuvelet(korok, felnott);
console.log(felnottek);

function interjukerdes(foglalkozas){
    if (foglalkozas == "tanar"){
        return function(nev){
            console.log(nev + "Meg tdná mondani mit tanít?");
        }
    }
    else if (foglalkozas == 'elado') {
        return function(nev) {
            console.log(nev + ', hogyan kezel egy vevő reklamációt?');
        }
    }
    else{
        return function(nev){
            console.log('Mi a foglalkozása?' + nev + '?');
        }
    }
}

var kerdestan = interjukerdes('tanar');
kerdestan('pál');

var kerdeseladoknak = interjukerdes('elado')
kerdeseladoknak('Teri');
kerdeseladoknak('Feri');
kerdeseladoknak('Ági');

interjukerdes('tanar')('Péter');
interjukerdes('Programozo')('Ödön');