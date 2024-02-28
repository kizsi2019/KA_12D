var odon = {
    nev : 'Ödön',
    kor : 45,
    foglalkozas: 'csillagász',
    udvozlet: function(stilus, napszak) {
        if( stilus === 'hivatalos') {
            console.log('Üdvözlöm, jó ' + napszak + ' kívánok ' + this.nev + ' vagyok ');
        }
        else if (stilus === 'baráti') 
        {
            console.log('Szia, jó ' + napszak + '!');
        }
    }
}

odon.udvozlet('hivatalos', 'hajnalt');
odon.udvozlet('baráti', 'estét');

var bela = {
    nev : 'Béla',
    kor : 62,
    foglalkozas: 'portás',
}

odon.udvozlet('hivatalos', 'hajnalt');
odon.udvozlet('baráti', 'estét');
odon.udvozlet.call(bela,'baráti', 'estét');
odon.udvozlet.apply(bela,['baráti', 'estét']);

var odonbrati = odon.udvozlet.bind(odon, 'baráti');
odonbrati('napot');
odonbrati('estét');

var belahivat = odon.udvozlet.bind(bela, 'hivatalos');
var belahivatregg = odon.udvozlet.bind(bela, 'hivatalos', 'reggel');

belahivat('estét');
belahivatregg();


var evek = [1954, 1990, 1963, 2000, 2010];

function tombmuvelet(tomb, fv){
    var eredmeny = [];
    for (var i = 0; i < tomb.length; i++){
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}

function kosrszamitas(elem){
    return 2024 - elem;
}

function felnott(korhatar, elem) {
    return elem >= korhatar;
}

var korok = tombmuvelet(evek, kosrszamitas);

console.log(evek);
console.log(korok);

var felnottjapanban = tombmuvelet(korok, felnott.bind(this, 20));

console.log(felnottjapanban);