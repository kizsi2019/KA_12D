const dobozES62 = {
    szin: 'zöld',
    pozicio: 1,
    kattintsRam: () => {
        document.querySelector('.zold').addEventListener('click', () => {
            var szoveg = 'Én vagyok a(z) ' + this.pozicio + '. doboz és a színem ' + this.szin + '.';
            alert(szoveg);
        })
    }
};

dobozES62.kattintsRam();