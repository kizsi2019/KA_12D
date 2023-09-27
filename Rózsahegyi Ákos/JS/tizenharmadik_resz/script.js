// Tömbök (Arrays)
var nev1 = "Ond";
var nev2 = "Kend";
var nev3 = "Tosz";

var nevek = ["Ond", "Kend", "Tosz"];
var korok = new Array(35, 42, 38);

console.log(korok[1]);
console.log(nevek);
console.log(nevek.length);

nevek[1] = "Huva";
console.log(nevek);

nevek[nevek.length] = "Álmos";
console.log(nevek);

var huba = ["Huba", 38, "Vezér", true];
console.log(huba);

huba.push(42); // sor végére illeszt
console.log(huba);

huba.unshift("ifj"); // sor elejére illeszt
console.log(huba);

huba.pop(); // sor végéről töröl
console.log(huba);

huba.shift(); // sor elejéről töröl
console.log(huba);

console.log(huba.indexOf(38)); // kiírja az elem indexét

var szakacs = huba.indexOf("Szakács") === -1 ? "Huba nem szakács" : "Huba szakács";
console.log(szakacs);