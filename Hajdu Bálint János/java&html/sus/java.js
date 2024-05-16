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
