var szamlalo = 0;
function leptet()
{
    szamlalo++;
    console.log(szamlalo);
}
leptet();
leptet();
leptet();

var szamlalo = 0;
function leptet()
{
    var szamlalo = 0;
    return function()
    {
        szamlalo++;
        console.log(szamlalo);
    }
}
var hozzaad = leptet();
hozzaad();
hozzaad();
hozzaad();

var leptet = 
(
    function()
    {
        var szamlalo = 0;
        return function()
        {
            szamlalo++;
            console.log(szamlalo);
        }
    }
)();