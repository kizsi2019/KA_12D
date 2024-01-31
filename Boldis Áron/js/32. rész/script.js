document.getElementById("buliBtn").onclick = function(){
    setInterval(() =>{
        var color = Math.floor(Math.random()*16777215).toString(16);
        document.body.style.backgroundColor = "#" + color;
    },500);
}


//objektum léthrehozása

/*var odon = {
    nev: "Ödön",
    szuletesiEv: 1978,
    foglalkozás: "grafikus"
};*/

/*var Szemely = function(nev, szuletesiEv, foglalkozas){
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozás = foglalkozas;

    /*this.korszamitas = function(){
        console.log(2024 - this.szuletesiEv);
    }
};

var odon = new Szemely("Ödön", 1979, "grafikus")
odon.korszamitas();

var erzsi = new Szemely("Erzsi", 1950, "nyugdíjas")

console.log(Szemely);
console.log(odon);

Szemely.prototype.korszamitas = function(){
    console.log(2024 - this.szuletesiEv);
}

Szemely.prototype.teszt = "teszt";*/
