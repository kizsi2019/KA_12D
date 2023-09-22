var eletSzakaszok = function(nev,kor){
    switch (true) {
        case kor <13:
            return nev + 'gyerek';
            break;
        case kor >=13 && kor <=20:
            return nev+'ifju';
            break;
        case kor >30 && kor <=50:
            return nev +'kozepkoru';
            break;
        default:
            return nev + 'idős'

    }
}

console.log(eletSzakaszok('kati',12));
console.log(eletSzakaszok('peti',20));
console.log(eletSzakaszok('mark',67));