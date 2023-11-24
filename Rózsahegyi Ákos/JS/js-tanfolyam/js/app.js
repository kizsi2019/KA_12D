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

var pontszamok, korpontszam, aktivJatekos;

init();

// dobás gomb kezelője
document.querySelector('.btn-roll').addEventListener('click', function() {
  // kell egy véletlen szám
  var kocka = Math.floor(Math.random() * 6) + 1;

  // eredmény megjelenítése
  var kockaDOM = document.querySelector('.dice');
  kockaDOM.style.display = 'block';
  kockaDOM.src = 'img/dice-' + kocka + '.png';
    
  // körben elért pontszám frissítése, ha nem 1-et dobunk
  if (kocka !== 1) {
      korpontszam += kocka;
      document.querySelector('#current-' + aktivJatekos).textContent = korpontszam;
  }
  else {
      kovetkezoJatekos();
  }
});

// megtartom gomb eseménykezelője
document.querySelector('.btn-hold').addEventListener('click', function() {
    // összes pontszám frissítése a kódban
    pontszamok[aktivJatekos] += korpontszam;

    // összes pontszám frissítése a felületen (UI)
    document.querySelector('#score-' + aktivJatekos).textContent = pontszamok[aktivJatekos];
    
    // nyert a játékos?
    if (pontszamok[aktivJatekos] >= 20) {
        document.querySelector('#name-' + aktivJatekos).textContent = 'Győztes!';
        document.querySelector('#name-' + aktivJatekos + '-panel').classList.add('winner');
        document.querySelector('#name-' + aktivJatekos + '-panel').classList.remove('active');
    }
    else {
        kovetkezoJatekos();
    }
});

function kovetkezoJatekos() {
    aktivJatekos === 0 ? aktivJatekos = 1 : aktivJatekos = 0;
    korpontszam = 0;
      
    document.getElementById('current-0').textContent = '0';
    document.getElementById('current-1').textContent = '0';
      
    document.querySelector('.player-0-panel').classList.toggle('active');
    document.querySelector('.player-1-panel').classList.toggle('active');
      
    document.querySelector('.dice').style.display = 'none';
}

// új játék létrehozása
document.querySelector('.btn-new').addEventListener('click', init);

// init
function init() {
  pontszamok = [0,0];
  korpontszam = 0;
  aktivJatekos = 0;

  document.querySelector('.dice').style.display = 'none';
  document.getElementById('score-0').textContent = '0';
  document.getElementById('current-0').textContent = '0';
  document.getElementById('score-1').textContent = '0';
  document.getElementById('current-1').textContent = '0';

  document.getElementById('name-0').textContent = 'Frodó';
  document.getElementById('name-1').textContent = 'Samu';
  document.querySelector('.player-0-panel').classList.remove('winner');
  document.querySelector('.player-1-panel').classList.remove('winner');
  document.querySelector('.player-0-panel').classList.remove('active');
  document.querySelector('.player-1-panel').classList.remove('active');
  document.querySelector('.player-0-panel').classList.add('active');
}