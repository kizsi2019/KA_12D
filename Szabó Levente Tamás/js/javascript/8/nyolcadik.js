function interju(foglalkozas)
{
    if (foglalkozas == 'tanar)'
    {
        return function(nev)
        {
            console.log(nev + 'meg tudod mondani mit tanítasz?')
        }
    }
    else if (foglalkozas = 'elado')
    {
        return function(nev)
        {
            console.log('Mit adsz el?')
        }
    }
    else
    {
        return function(nev)
        {
            console.log('Mit dolgozol' + nev + '?')
        }
    }
}
var kerdesTanar = interju('tanar');
kerdesTanar('A')
var kerdesElado = interju('elado')
kerdesElado('hehe');
kerdesElado('Huo');
kerdesElado('hmm');
interju('tanar')('A');
interju('programozo')(Peti);