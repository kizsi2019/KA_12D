π = 3,14
function kor(π, r, funkcio)
{
    var eredmeny;
    {
        if (funkcio === 'kerület')
        {
            eredmeny = 2 * r * π;
        }
         else if (funkcio === 'terület')
        {
            eredmeny = 2 * π;
        }
        else
        {
            return 'Hibás funkció!';
        }
        return funkcio + ' = ' + eredmeny;
    }   

}
console.log(kor(5, 4, 'kerület'));
console.log(kor(5, 4, 'terulet'));