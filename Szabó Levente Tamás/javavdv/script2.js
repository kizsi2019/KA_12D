/*function hello(nev)
{
    return 'Helló' + nev + '!'
}

var ertek = hello('Géza');
console.log(ertek);*/

function teglalapteruletkerulet(a, b, funkcio)
{
    var eredmeny;
    if(funkcio === 'kerület')
    {
        eredmeny = (a + b) * 2;
    }
    else if (funkcio === 'terület')
    {
        eredmeny = a * b;
    }
    else
    {
        return 'Hibás funkció!';
    }
    return funkcio + ' = ' + eredmeny;
}
console.log(teglalapteruletkerulet(5, 4, 'kerület'));
console.log(teglalapteruletkerulet(5, 4, 'terulet'));