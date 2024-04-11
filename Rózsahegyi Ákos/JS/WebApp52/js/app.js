//Költségvetésvezérlő

var koltsegvetesVezerlo = (function() {
    var Kiadas = function (id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = ertek;
    }

    var Bevetel = function (id, leiras, ertek) {
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
    return {
        tetelHozzaad: function (tip, lei, ert) {
            var ujTetel, ID;
            ID = 0;

            //ID létrehozása
            if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0) {
                ID = adat.tetelek[tip][adat.tetelek[tip].length - 1].id + 1;
            } else {
                ID = 0;
            }

            //Új kiadás vagy bevétel létrehozás
            if (tip === 'bev') {
                ujTetel = new Bevetel(ID, lei, ert);
            } else if (tip === 'kia') {
                ujTetel = new Kiadas(ID, lei, ert);
            } else {
                // Hibakezelés, dobjon hibát vagy állítsa 'ujTetel'-t 'null'-ra
                throw new Error('Invalid tip: ' + tip);
            }

            //Új tétel hozzáadása az adatszerkezethez
            if (adat.tetelek[tip] !== undefined) {
                adat.tetelek[tip].push(ujTetel);
            }
            return ujTetel; //Új tétel visszaadása
        },

        teszt: function() {
            console.log(adat);
        }
    }
})();

//Felületvezérlő
var feluletVezerlo = (function() {

    var DOM_elemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb',
        bevetelTarolo: '.bevetelek__lista',
        kiadasTarolo: '.kiadasok__lista'
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
        },

        tetelMegjelenites: function(obj, tipus) {
            var html, ujHtml, elem;

            //HTML string létrehozása placeholder értékekkel
            if (tipus === 'bev') {
                elem = DOM_elemek.bevetelTarolo;
                html = '<div class="tetel clearfix" id="bevetelek-0"> <div class="tetel__leiras">Fizetés</div> <div class="right clearfix"> <div class="tetel__ertek">+ 2,100.00</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>'
            } else if (tipus === 'kia') {
                elem = DOM_elemek.kiadasTarolo;
                html = '<div class="tetel clearfix" id="expense-0"> <div class="tetel__leiras">Lakás bérleti díj</div> <div class="right clearfix"> <div class="tetel__ertek">- 900.00</div> <div class="tetel__szazalek">21%</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>'
            }
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