var eletszakaszok = function(nev, kor) {
    switch (true) {
        case kor < 13:
            return nev + ' gyerek';
            break;
        case kor >= 13 && kor <= 20:
            return nev + ' tinédzser';
            break;
        case kor >= 20 && kor <= 30:
            return nev + ' ifjú';
            break;
        case kor >= 30 && kor <= 50:
            return nev + ' középkórú';
            break;  
        default:
            return nev + 'idős';      
    }
}

console.log(eletszakaszok('kati,12'));
console.log(eletszakaszok('Peti,69'));
console.log(eletszakaszok('Mérk,20'));