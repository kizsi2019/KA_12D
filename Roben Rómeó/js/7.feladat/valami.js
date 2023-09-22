var film = 'gladiator';
var mufaj;

switch (film){
    case 'shrek' : mufaj = 'romantika'
        break;
    case 'terminator' : mufaj = 'vígjáték'
        break;
    case 'nők jogai' : mufaj = 'sci-fi'
        break;
    default :
        mufaj = 'besorolatlan'

    
}

console.log(mufaj);

var kor = 40;
var  nev ='bela';

switch (true){
    case kor  < 13:
        console.log(nev + '  kisfiú')
        break;
    case kor >= 13 && kor <= 20:
        console.log(nev + '  tinédzser')
        break;
    case kor >= 20 && kor <= 30:
        console.log(nev + '  fiatalember') 
        break;
    default :
        console.log(nev + '  igazi férfi,csak mint péter')
        

    
}
