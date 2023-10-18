var huba = {
    nev: "huba",
    kor: 40,
    foglalkozas: "vezér",
    hazas: true,
    baratok: ["Álmos", "Előd", "Ond"],
    "csaladi allapot": "nős",
    szuletesiEvszamitas: function(){
        this.szuletesiEv = 2020 - this.kor;
    }
};

huba.szuletesiEvszamitas();
console.log(huba);

for (var i = 20; i >= 1; i--){
    console.log(i)
}

var tomb = ["Ond", 38, "vezér", true, 1990];

for (var i = 0; i < tomb.length; i++){
    console.log(tomb[i]);
}

while(i < tomb.length){
    console.log(tomb[i]);
    i++;
}

for(var i = 0; i < tomb.length; i++){
    if (typeof(tomb[i]) === "boolean"){
        break;
    }
    console.log(tomb[i]);
}

for (var i = 0; i < tomb.length; i++){
    if (typeof(tomb[i]) !== "string"){
        continue;
    }
    console.log(tomb[i])
}