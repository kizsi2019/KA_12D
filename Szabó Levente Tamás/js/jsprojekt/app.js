//1//
//let const
//es5
var nev5 = 'guba';
var kor = '1000';
nev5 = 'shork';
console.log(nev5)

function nyelvVizsga5(siker){
    if (siker){
        var keresztnev = 'guba';
        var szuletesEv = 1;
        console.log(keresztnev + ' (születési év: ' + szuletesEv + ') sikeres vizsga volt');
    }
}

nyelvVizsga5(true);
//es6
const nev6 = 'guba';
let kor6 = '1000';
//nev6 = 'neves'; //hibás
//console.log(nev6)

nyelvVizsga6(true);
let i = 9;
for (let i = 0; i < 5; i++){
    console.log(i);
}
console.log(i);