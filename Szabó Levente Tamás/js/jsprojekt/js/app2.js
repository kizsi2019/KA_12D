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

var i = 9;
for (var i = 0; i < 5; i++){
    console.log(i);
}
console.log(i);
//2//
////////////////////////////////
/////////Blokkok és IFE/////////
////////////////////////////////
{
    const a = 1;
    let b = 2;
    var c = 3;
}
//console.log(a + b);

(function(){
    var c = 3;
}());
console.log(c);

if (c + 1 == 4){
    console.log("gubba");
}
else{
    console.log("nem gubba");
}