var peti = {
    nev : 'Peti',
    kor: 40,
    foglalkozás: 'szerelemegér',
    hazas: true,
    baratok:['Áron','Bálint','Bazsi',],
    szeletesievszamitas: function(){
        this.szuletesiev =2023 - this.kor;
    }
}

peti.szeletesievszamitas();

console.log(peti);