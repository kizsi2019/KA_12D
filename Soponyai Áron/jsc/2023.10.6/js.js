var tomb = ["Ond", 38, "vezér", true, "1990"]
for (var i = 0; i < 1; i++)
{
    if (typeof(tomb[i]) === "boolean")
    {
        break;
    }
    console.log(tomb[i]);
}

for (var i = 0; i < tomb.length; i++)
{
    if (typeof(tomb[i]) !== "boolean")
    {
        continue;
    }
    console.log(tomb[i]);
}

var teszt = 10;
console.log(teszt);
console.log(window.teszt);
console.log(window["teszt"]);

function egy() 
{
    console.log(teszt);
}

egy();
window.egy();