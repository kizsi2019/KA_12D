var evek = [1954,1990,1963,2003,2002]

function tombMuvelet(tomb, fv){
    var eredmeny = [];
    for (var i=0; i < tomb.length; i++){
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}
function korSzamitas(elem){
    return 2021 - elem;
}
function felnott(elem){
    return elem >= 18;
}
var korok = tombMuvelet(evek, korSzamitas);
console.log(korok);

var felnottek = tombMuvelet(evek, korSzamitas);
console.log(korok);