function interjuKerdes(foglalkozas){
    if (foglalkozas == 'tanar'){
        return function(nev){
            console.log(nev + ', meg tudná mondani, hogy milyen tárgyakat tanít?');
        }
    }
    else if (foglalkozas == 'elado'){
        return function(nev){
            console.log(nev + ', hogyan kezeli a reklamációt?');
        }
    }
    else{
        return function(nev){
            console.log('Mi a foglalkozása kedves ' + nev + '?');
        }
    }
}

var kerdesTanaroknak = interjuKerdes('tanar');
kerdesTanaroknak('Pál');

var kerdesEladoknak = interjuKerdes('elado');
kerdesEladoknak = interjuKerdes('Teri');
kerdesEladoknak = interjuKerdes('Feri');
kerdesEladoknak = interjuKerdes('Tomi');

interjuKerdes('tanar')('Péter');
interjuKerdes('programozo')('Ödön');