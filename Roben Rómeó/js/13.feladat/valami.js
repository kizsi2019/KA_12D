/*var evek = [1954, 1990, 1963, 2000, 2010];

function tombMuvelet(tomb, fv)
{
    var eredmeny = [];

    for (var i = 0; i< tomb.length; i++)
    {
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}

function felnott(elem)
{
    return elem>= 18;
}

function korszamitas(elem)
{
    return 2024 - elem;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(korok);

var felnottek = tombMuvelet (korok, felnott);
console.log(felnottek);*/

function interjuKerdes(foglalkozás)
{
    if ( foglalkozás =='tanar')
    {
        return function(nev)
        {
            console.log( nev +',milyen tárgyakat tanít?')
        }
    }

    else if ( foglalkozás =='elado')
    {
        return function(nev)
        {
            console.log( nev +',kedves a vevőkkel??')
        }
    }

    else  
    {
        return function(nev)
        {
            console.log( nev +',mivel foglalkozik???')
        }
    }
}

var kerdesTanarok = interjuKerdes('tanar');
kerdesTanarok('Peti');

var kerdesElado = interjuKerdes('elado');
kerdesElado('Áron');

var kerdesElado = interjuKerdes('elado');
kerdesElado('Roli');

var kerdesElado = interjuKerdes('elado');
kerdesElado('Bazsi');

interjuKerdes('tanar')('Bálint');
interjuKerdes('Programozó')('Adél');