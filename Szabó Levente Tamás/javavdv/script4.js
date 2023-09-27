//function(parameterek){}
//function eletszakaszok(nev, kor) {}

var eletszakaszok = function(nev, kor)
{
    switch (true)
    {
        case kor < 13:
            return nev + 'gyerek';
            break;
        case kor >= 13 && kor <= 20:
            return nev + 'tinédzser';
            break;
        case kor >= 20 && kor <= 30:
            return nev + 'ifjú';
            break;
        case kor >= 30 && kor <= 50:
            return nev + 'középkorú';
            break;
            default:
                return nev + 'idős';
    }
}