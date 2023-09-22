/*function hello(nev) {
    return('Hello ' + nev + '!');
}
console.log(hello('Géza'));*/

/*function teglelepKeruletTerulet(a, b, funkcio) {
    var eredmeny;
    
    if(funkcio === 'kerulet') {
        eredmeny = (a + b) * 2;
    } else if (funkcio === 'terulet') {
        eredmeny = a * b;
    } else {
        return 'Hibás funkció!'
    }

    return funkcio + ' = ' + eredmeny;
}

console.log(teglelepKeruletTerulet(5, 4, 'kerület'));
console.log(teglelepKeruletTerulet(5, 4, 'terület'));*/

function korKerulet(r, funkció) {
    var eredmeny;

    if (funkció === 'kerulet') {
        eredmeny = r * 3.14;
    } else {
        return 'Hibás funkció!'
    }
}

console.log(korKerulet(6, 'kerület'));

function korTerulet(r, funkció) {
    var eredmeny;

    if (funkció === 'terulet') {
        eredmeny = (2 * r) * 3.14;
    } else {
        return 'Hibás funkció!'
    }
}

console.log(korTerulet(6, 'terület'));