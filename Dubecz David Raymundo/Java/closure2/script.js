var odon = {
    nev: "Ödön",
    kor: 45,
    foglalkozas: "csillagász",
    udvozles: function(stilus, napszak){
        if (stilus === 'hivatalos') {
            console.log("Udv jo, " + napszak + " kivanok" + this.nev + " vagyok") 
        } else if (stilus === "baráti") {
            console.log("szia, jo" + napszak + '!'); 
        }
    }
}

odon.udvozlet("hivatalos", "hajnali");
odon.udvozlet("baráti", "estét");