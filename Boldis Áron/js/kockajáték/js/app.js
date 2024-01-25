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

var pontszamok, korPontszam, aktivjatekos;

init();


//document:.querySelector(*#current-" + aktivjatekos).textcontent = ‘<u>’ + kocka + '</u>"s


document.querySelector(".btn-roll").addEventListener("click", function(){
  //kell egy veletlen szm
  var kocka = Math.floor(Math.random() * 6) + 1;

  // eredmény megjelenitése
  var kockaDOM = document.querySelector(".dice");
  kockaDOM.style.display = "block";
  kockaDOM.src = "img/dice-" + kocka + ".png";

  if (kocka !== 1){
    korPontszam += kocka;
    document.querySelector('#current-' + aktivjatekos).textContent =  korPontszam;
  }
  else{
    kovetkezoJatekos();
  }
});

document.querySelector(".btn-hold").addEventListener("click", function(){
  pontszamok[aktivjatekos] += korPontszam;
  document.querySelector("#score-" + aktivjatekos).textContent = pontszamok[aktivjatekos];

  if (pontszamok[aktivjatekos] >= 15){
    document.querySelector("#name-" + aktivjatekos).textContent = "Győztes!";
    document.querySelector(".player-" + aktivjatekos + "-panel").classList.add("winner")
    document.querySelector(".player-" + aktivjatekos + "-panel").classList.remove("active")
  }
  else{
    kovetkezoJatekos();
  }
});

function kovetkezoJatekos(){
  aktivjatekos === 0 ? aktivjatekos = 1 : aktivjatekos = 0;
  korPontszam = 0;

  document.getElementById('current-0'.textContent = '0');
  document.getElementById('current-1'.textContent = '0');

  document.querySelector(".player-0-panel").classList.toggle("active");
  document.querySelector(".player-1-panel").classList.toggle("active");
  document.querySelector(".dice").style.display = "none";
};

document.querySelector(".btn-new").onclick = function() {
  init();
};

function init(){
  pontszamok = [0, 0];
  korPontszam = 0;
  aktivjatekos = 0;

  document.querySelector('.dice').style.display = "none";
  document.getElementById("score-0").textcontent = "0";
  document.getElementById("current-0").textcontent = "0";
  document.getElementById("score-1").textcontent = "0";
  document.getElementById("current-0").textcontent = "0";

  document.getElementById("name-0").textContent = "Frodó";
  document.getElementById("name-1").textContent = "Samu";
  document.querySelector(".player-0-panel").classList.remove("winner");
  document.querySelector(".player-1-panel").classList.remove("winner");
  document.querySelector(".player-0-panel").classList.remove("active");
  document.querySelector(".player-1-panel").classList.remove("active");
  document.querySelector(".player-0-panel").classList.add("active");
};