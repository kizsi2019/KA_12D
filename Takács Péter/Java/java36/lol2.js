function interjuKerdes(foglalkozas){
    if(foglalkozas == 'tanar'){
        return function(nev){
            console.log(nev+ ', hogyan kezel egy vevő reklamációt?')
        }
    }else if(foglalkozas == 'elado'){
        return function(nev){
            console.log(nev+ ', hogyan kezelne vevői reklamációt?')
        }
    } else {
        return function(nev){
            console.log('Mi a foglalkozása kedves'+ nev +'?' )
        }
    }   
}

var kerdesTanaroknak = interjuKerdes('Tanár');
kerdesTanaroknak('Pál');

var kerdesEladoknak = interjuKerdes('Eladó');
kerdesEladoknak('Katalin');
kerdesEladoknak('Feri');
kerdesEladoknak('Rómeó');

interjuKerdes('Tanár')('Péter');
interjuKerdes('programozó')('ödön');