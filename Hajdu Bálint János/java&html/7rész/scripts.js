var film ='Gladiator'
var mufaj;

switch(film) {
    case 'Shrek': mufaj ='mese'
        break
    case 'Terminator':mufaj='akcio'
        break
    case 'utazok':mufaj='sci-fi'
        break
    default:
        mufaj='besorolatlan';
}

console.log(mufaj)

var kor= 10;
var nev='Béla';

switch(true){
    case kor <13:
        console.log(nev+'kisfiu');
        break
    case kor>=13&&kor<=20:
        console.log(nev+'tini')
        break
    case kor>=20&&kor <20:
        console.log(nev+'tinif')
        break;
}
