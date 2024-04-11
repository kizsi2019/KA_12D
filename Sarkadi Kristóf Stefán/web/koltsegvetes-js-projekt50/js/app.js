//Költségvetésvezérlő
var koltsegvetesVezerlo = (function() {
    var kiadas = function(id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = ertek;
    }

    var bevetel = function(id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = ertek;
    }

    var adat = {
        tetelek: {
            bev: [{ id: 0 }],
            kia: [{ id: 0 }]
        },
        osszegek: {
            bev: 0,
            kia: 0
        }
    }
})();

//Felületvezérlő
var feluletVezerlo = (function() {

    var DOM_elemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb'
    }
    return {
        getInput: function() {
            return {
                tipus: document.querySelector(DOM_elemek.inputTipus).value,
                leiras: document.querySelector(DOM_elemek.inputLeiras).value,
                ertek: document.querySelector(DOM_elemek.inputErtek).value
            }
        },

        getDOM_elemek: function() {
            return DOM_elemek;
        }
    }

})();

//Alkalmazás vezérlő
var vezerlo = (function(koltsegvetesVez, feluletVez) {

    var esemenykezelokBeallit = function() {
        var DOM = feluletVezerlo.getDOM_elemek();
        document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzaadas);

        document.addEventListener('keydown', function(event) {
            if (event.key !== undefined && event.key === 'Enter') {
                vezTetelHozzaadas();
            } else if (event.keyCode !== undefined && event.keyCode === 13) {
                vezTetelHozzaadas();
            }
        });
    }

    vezTetelHozzaadas = function() {
        // 1. bevitt adatok megszerzése
        var input = feluletVezerlo.getInput();
        console.log(input);

        // 2. adatok átadása a koltsegvetesVezerlo modulnak


        // 3. Megjelenítés UI-n


        // 4. Költségvetés újraszámolása


        // 5. Összeg megjelenítése a felületen
        
    }
    return {
        init: function() {
            console.log("Alkalmazás fut");
            esemenykezelokBeallit();
        }
    }

})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();
