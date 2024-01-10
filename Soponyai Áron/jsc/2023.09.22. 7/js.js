var eletszakaszok = function(nev, kor)
{
    switch(true){
        case kor < 13:
            return nev + ' gyerek';
            break;
        case kor >= 13 && kor <=20:
            return nev + ' tinédzserek';
            break;
        case kor > 20 && kor <= 30:
            return nev + ' ifju';
            break;
        case kor > 30 && kor <=50:
        return nev + ' kozaepkoru';
        break;
        default:
            return nev + ' idos';
    }
}
console.log(eletszakaszok('kati',12));
console.log(eletszakaszok('peti',20));
console.log(eletszakaszok('márk',67));
