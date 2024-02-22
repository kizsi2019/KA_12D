// A függvények

function hello(nev) {
    return("Helló " + nev + "!");
}

// console.log(hello("Gabi Néni, én vagyok az, a Józsi"));
var ertek = hello("Gabi Néni, én vagyok az, a Józsi");
console.log(ertek);

/*
function teglalapKeruletTerulet(a, b, funkcio) {
    var eredmeny;

    if (funkcio === "kerület") {
        eredmeny = (a + b) * 2;
    } else if (funkcio === "terület") {
        eredmeny = a * b;
    } else {
        return "Hibás funkció"
    }

    return funkcio + " = " + eredmeny;
}

console.log(teglalapKeruletTerulet(5, 4, "kerület"));
console.log(teglalapKeruletTerulet(5, 4, "terület"));
*/

function korKerulet(sugar) {
    var eredmeny;

    eredmeny = (2 * sugar) * 3.14
    return "Kerület = " + eredmeny
}

function korTerulet(sugar) {
    var eredmeny;

    eredmeny = (sugar * sugar) * 3.14
    return "Terület = " + eredmeny
}

console.log(korKerulet(5));
console.log(korTerulet(5));