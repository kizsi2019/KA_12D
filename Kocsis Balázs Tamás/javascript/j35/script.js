//Függvények
/*var
-a függény az object típus egy példánya
-emiatt a függvény úgy viselkedik mint bármelyik más objektum
-egyetlen változóban tárolhatunk egy egész függvényt
-egy függvényt átadhatunk egy másik függvénynek mint paraméter
-ez utóbbihoz hasonló hogy egy függvény visszatérési értéke lehet egy függvény 
is nem csak szimpla érték vagy objektum vagy épp semmi*/

var evek = [1954, 1990, 1963, 2000, 2010];

function tombMuvelet(tomb, fv){
    var eredmeny = [];

    for (var i = 0; i < tomb.length; i++){
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}

function korszamitas(elem){
    return 2024 - elem;
}

var korok = tombMuvelet(evek, korszamitas);
console.log(korok);

function felnott(elem){
    return elem >= 18;
}

var felnottek = tombMuvelet(korok, felnott);
console.log(felnottek)