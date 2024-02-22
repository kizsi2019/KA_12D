// Apply, Bind, Call (https://www.youtube.com/watch?v=V0zysk71hsE&list=PLVyg_FEqWfkIvEQvgucUT6nQvQt4hQCgX&index=40)

var sigma = {
    nev: "Gigachad",
    kor: 45,
    foglalkozas: "Csillagász",
    udvozlet: function(stilus, napszak) {
        if (stilus === "hivatalos") {
            console.log("Üdvözlöm, jó " + napszak + " kívánok! " + this.nev + " vagyok")
        } else if (stilus === "baráti") {
            console.log("Szia, jó " + napszak + "!")
        }
    }
}

sigma.udvozlet("hivatalos", "hajnalt");
sigma.udvozlet("baráti", "estét");

var nagyfater = {
    nev: "Nagyfater Bátyó",
    kor: 62,
    foglalkozas: "Portás"
}

// Call metódus (függvény hívás)

sigma.udvozlet.call(nagyfater, "hivatalos", "estét")

// Apply metódus (függvény hívás, tömb elemek)
sigma.udvozlet.apply(nagyfater, ["baráti", "reggelt"])

// Bind (félkész metódusok)
var sigmaBarati = sigma.udvozlet.bind(nagyfater, "baráti");
sigmaBarati("napot");
sigmaBarati("estét");

var nagyfaterHivatalos = sigma.udvozlet.bind(nagyfater, "hivalatos");
var nagyfaterHivatalosReggeli = sigma.udvozlet.bind(nagyfater, "hivatalos", "reggelt");
nagyfaterHivatalos("estét");
nagyfaterHivatalosReggeli();