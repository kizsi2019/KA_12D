// Igaz és hamis értékek (falsy, truthy)
// false: undefined, null, 0, "", NaN

var szam;

szam = 10;

/*
if (szam || szam === 0) {
    console.log("Létezik")
} else {
    console.log("Nem létezik")
}
*/

// ==, ===

if (szam === '10') {
    console.log("Egyezik")
} else {
    console.log("Nem egyezik")
}