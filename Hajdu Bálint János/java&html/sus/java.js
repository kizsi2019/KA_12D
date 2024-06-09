/*
const dobozES62 ={
    szin:'zöld',
    pozicio:1,
    kattintsRam:()=> {
        document.querySelector('.green').addEventListener('click',()=>{
            var szoveg ='En vagyok a(z)'+this.pozicio+'-doboz és szinem'+this.szin+'.';
            alert(szoveg);
        })
    }
};
dobozES62.kattintsRam();*/

function Szemely(nev){
    this.nev=nev;
}

Szemely.prototype.barataimES5 =function(haverok){
    console.log(this.nev);
    var obj =this ;
    var tomb =haverok.map =(function(elem){
        return obj.nev + 'baratja '+elem +'.';
    });
    console.log(tomb);
}
var haverok =['Laci,Peti,Aron'];
new Szemely('Romeo').barataimES5(haverok);

Szemely.prototype.barataimES6=function(haverok){
    const tomb=haverok.map(elem=>`${this.nev}baratja${elem}.`);
    console.log(tomb);
}
new Szemely('Romeo').barataimES6(haverok);















var Laci =['Laci',50]
var nev =Laci[0];
var kor = Laci[1];

console.log(nev);
console.log(kor);

const [nev2,kor2]=['Laci',50];
console.log(nev2);
console.log(kor2);



const obj = {
    keresztNev:'Laci',
    vezetekNev:'Bödön'
};

const {keresztNev,vezetekNev}=obj;
console.log(vezetekNev);
console.log(keresztNev);

console.log(x);
console.log(y);

function korEsNyugdij (szuletesiEv){
    let nyugdijKorhatar=65;
    const kor =new Date().getFullYear()-szuletesiEv;
    return[kor,nyugdijKorhatar-kor]
}
const [kor3 ,nyugdij]=korEsNyugdij(1978);
console.log(kor3);
console.log(nyugdij);


const dobozok =document.querySelectorAll('.rectangle');
var dobozokTombES5=Array.prototype.slice.call(dobozok)
dobozok.forEach(function(aktualis){
    aktualis.style.backgroundColor='orange';
});


const dobozES62=Array.from(dobozok);
dobozokTombES6.forEach(aktualis=>aktualis.style.backgroundColor='blue');

for (var i =0;i<dobozokTombES5.length;i++){
    if(dobozokTombES5[i].className==='rectangle blue'){

    }
    dobozokTombES5[i].textContent='Kék lettem'
}

for (const aktualis of dobozokTombES6){
    if (aktualis.className ==='rectangle blue'){
        continue;
    }
    aktualis.textContent='kék lettem';
}

var korok = [2,10,20,17,14]
console.log(korok);
var feknott = korok.map (function(aktualis){
    return aktualis>=18;

});
console.log(felnottek);

console.log(felnottek.indexof(true));
console.log(korok.findIndex(aktualis=>aktualis>=18));
console.log(korok.find(aktualis=>aktualis>=18));