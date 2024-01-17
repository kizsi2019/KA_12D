document.addEventListener('DOMContentLoaded', () => {
    const cardValues = ['A', 'A', 'B', 'B', 'C', 'C', 'D', 'D', 'E', 'E', 'F', 'F', 'G', 'G', 'H', 'H'];
    let cards = [];
    let flippedCards = [];
    let lockBoard = false;
  
    function shuffle(array) {
      return array.sort(() => Math.random() - 0.5);
    }
  
    // ... (a többi rész ugyanaz marad)

function createBoard() {
    const shuffledCards = shuffle(cardValues);
    const gameBoard = document.querySelector('.memory-game');
  
    shuffledCards.forEach((value, index) => {
      const card = document.createElement('div');
      card.classList.add('card');
      card.dataset.value = value;
      card.dataset.index = index;
  
      const cardText = document.createElement('div');
      cardText.classList.add('card-text');
      cardText.innerText = value;
  
      card.appendChild(cardText);
  
      card.addEventListener('click', flipCard);
      gameBoard.appendChild(card);
    });
  
   
  
  
      cards = document.querySelectorAll('.card');
    }
  
    function flipCard() {
      if (lockBoard) return;
      if (this === flippedCards[0]) return;
  
      this.classList.add('flipped');
      flippedCards.push(this);
  
      if (flippedCards.length === 2) {
        lockBoard = true;
        setTimeout(checkMatch, 500);
      }
    }
  
    function checkMatch() {
      const [firstCard, secondCard] = flippedCards;
      const isMatch = firstCard.dataset.value === secondCard.dataset.value;
  
      isMatch ? disableCards() : unflipCards();
  
      if (checkWin()) {
        alert('Gratulálok! Nyertél!');
        resetGame();
      }
  
      resetBoard();
    }
  
    function disableCards() {
      flippedCards.forEach(card => card.removeEventListener('click', flipCard));
      resetBoard();
    }
  
    function unflipCards() {
      lockBoard = true;
      setTimeout(() => {
        flippedCards.forEach(card => card.classList.remove('flipped'));
        resetBoard();
      }, 1000);
    }
  
    function resetBoard() {
      [lockBoard, flippedCards] = [false, []];
    }
  
    function checkWin() {
      return Array.from(cards).every(card => card.classList.contains('flipped'));
    }
  
    function resetGame() {
      const gameBoard = document.querySelector('.memory-game');
      gameBoard.innerHTML = '';
      createBoard();
    }
  
    createBoard();
  });
  