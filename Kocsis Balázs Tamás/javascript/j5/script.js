var huba = {
    nev: 'Huba',
    kor: 40,
    foglalkozas: 'vezér',
    hazas: true,
    baratok: ['Álmos', 'Előd', 'Ond'],
    'csaladi allapot': 'nős',
    szuletesiEvSzamitas: function(){
        this.szuletesiEv = 2003 - this.kor;
    }
};

huba.szuletesiEvSzamitas();

console.log(huba);