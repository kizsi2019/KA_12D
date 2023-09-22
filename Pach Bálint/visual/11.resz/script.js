/*function hello(nev) {
    return 'Helló ' + '!';

}

var ertek = hello('Géza');
console.log(ertek);*/

function teglalapKerulet(a, b, funkcio) {
    var eredmeny;

    if (funkcio === 'kerület') {
        eredmeny = (a + b) * 2;
    } else if (funkcio === ' terület') {
        eredmeny = a * b;
    } else {
        return 'Hibás funkcio!';
    }

    return funkcio + ' = ' + eredmeny;

}   

console.log(teglalapKeruletTerulet(5, 4, 'kerület'));
console.log(teglalapKeruletTerulet(5, 4, 'terület')); 
