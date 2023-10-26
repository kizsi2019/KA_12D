/*
Játék szabályok:

- A játék 2 szereplős és körökre osztott
- Minden egyes körben az adott játékos dob a kockával, ahányszor csak szeretne. A dobások eredménye hozzáadódik a játékos adott körben
  elért pontszámához, ami értelem szerűen minden körben nulláról indul.
- Ha az aktuális játékos 1-et dob, akkor az összes addigi pontja elveszik, és átadja a dobás jogát a következő játékosnak.
- A játékos választhatja a 'Megtartom' gombot is. Ebben az esetben az adott körben elért pontok száma, hozzáadódik a játékos összes
  pontszámához. Majd a dobás joga a másik játékosra száll.
- Az a játékos nyer, aki előbb eléri a 100 pontot.  

*/

var pontszamok, korPontszamok;

pontszam1 = [0,0]
korPontszamok = 0;

aktivJatekos = 1;

//document.querySelector("#current-").textContent = kocka;
//var nev = document.querySelector("#name-aktivJatekos").textContent = '<u>' + kocka + '</u>';

document.querySelector('.dice').style.display = 'none';

document.querySelector('.btn-roll').addEventListener('click', function(){
  //kell egy veletlen szám
  kocka = Math.floor(Math.random() * 6) + 1;
  
  //eredmény megjelenitése
  var kockaDOM = document.querySelector('.dice');
  kockaDOM.style.display = 'block';
  kockaDOM.src = 'img/dice-' + kocka+ '.png'

  //körben elért pontszám frissítése, ha nem 1-et dobunk


});