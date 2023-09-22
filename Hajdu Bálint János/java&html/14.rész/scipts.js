var huba ={
    nev:'Huba',
    kor:38,
    foglalkozas:'vezér',
    hazas:true,
    barotok:['Álmos' , 'Előd','Ond'],
    csaladiallapot:'nös'
};

console.log(huba.foglalkozas);
console.log(huba['nev']);

var h ='hazas';
console.log(huba[h]);


console.log(huba['csaladiallapot']);

huba['kor']=40;
huba.foglalkozas='ács'

console.log(huba);

var tas =new Object();

tas.nev='Tas';
tas.kor=32;
tas['foglalkozas']='vezér'
console.log(tas);