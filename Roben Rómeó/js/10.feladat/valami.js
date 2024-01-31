var peti = {
    nev : 'Peti',
    kor: 69,
    foglalkozás: 'szerelemegér',
    hazas: true,
    baratok:['Áron','Bálint','Bazsi',],
    szeletesievszamitas: function(){
        this.szuletesiev =2024 - this.kor;
    }
}

peti.szeletesievszamitas();

console.log(peti);