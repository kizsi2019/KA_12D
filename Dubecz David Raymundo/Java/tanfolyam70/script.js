var nev5 = 'Teszt Elek';
var kor5 = 40;

nev5 = 'Kiss Pista';

console.log(nev5);

function nyelvVizsa5(siker) {
    if (siker) {
        var keresztnev ='Ödön';
        var szuletesiev = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiev + ') sikeres a vizsga');
    }
}

nyelvVizsa5(true);

const nev6 = 'Teszte Elek';
let kor6 = 40;

console.log(nev6);

function nyelvVizsa6(siker) {
    if (siker) {
        let keresztnev ='Ödön';
        const szuletesiev = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiev + ') sikeres a vizsga');
    }
}

nyelvVizsa6(nev6);

let i = 9;
for (let i = 0; i < 5; i++) {
    console.log(i);
}

console.log(i);


var x = 9;
for (var x = 0; x < 5; x++) {
    console.log(x);
}

console.log(x);

let vezeteknev3 = 'Vicc';
let keresztnev3 = 'Elek';
const szuletesiev2 = 1970;

function korszamitas(ev) {
    return 2024 - ev;
}

console.log(vezeteknev3 + ' ' + keresztnev3 + ' ' + szuletesiev2 + '-ben született. Most ' + korszamitas(szuletesiev2) + 'éves.');

console.log(`${vezeteknev3} ${keresztnev3}, szuletett ${szuletesiev2}-ben. Most ${korszamitas(szuletesiev2)} eves.`)