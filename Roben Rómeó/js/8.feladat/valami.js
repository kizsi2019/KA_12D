/*function hello( nev) {
    return 'Hello' + nev + '|';

}

var ertek = hello('géza');
console.log(ertek);*/

function teglalapkeruletTerület(a,b,funcio) {
    var eredmeny;

    if (funkcio === 'kerület') {
        eredmény = (a+b) * 2;
    }
        else if (funkcio === 'terület') {
        eredmény = a*b;
    }   else {
        return ' Hibás Funkcio';
    }
    return 'funkcio' + '=' + eredmény;

}

console.log(teglalapkeruletTerület(5,4,'kerület'));
console.log(teglalapkeruletTerület(5,4,'terület'));
console.log(teglalapkeruletTerület(5,4,'jhdkndjkn'));