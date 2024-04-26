//Költségvetésvezérlő

var koltsegvetesVezerlo = (function() {
    var Kiadas = function (id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = parseInt(ertek);
    }

    var Bevetel = function (id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = parseInt(ertek);
    }

    var vegosszegSzamolas = function(tip) {
        var osszeg = 0;
        if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0) {
            adat.tetelek[tip].forEach(function(currentvalue) {
                if (!isNaN(currentvalue.ertek)) {
                    osszeg += currentvalue.ertek;
                }
            });
            adat.osszegek[tip] = osszeg;
        }
    }

    var adat = {
        tetelek: {
            bev: [{ id: 0 }],
            kia: [{ id: 0 }]
        },
        osszegek: {
            bev: 0,
            kia: 0
        },
        koltsegvetes: 0,
        szazalek: -1
    }
    return {
        tetelHozzaad: function (tip, lei, ert) {
            var ujTetel, ID;

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
        
        koltsegvetesSzamolas: function() {
            // 1. Bevitel és kiadások összegének kiszámítása
            vegosszegSzamolas('bev');
            vegosszegSzamolas('kia');

            // 2. Költségvetés kiszámítása: bevétel - kiadások
            adat.koltsegvetes = adat.osszegek.bev - adat.osszegek.kia;

            // 3. Százalék számolása: kiadások / bevétel * 100
            if (adat.osszegek.bev > 0) {
                adat.szazalek = Math.round((adat.osszegek.kia / adat.osszegek.bev) * 100);
            }
            else {
                adat.szazalek = -1;
            }
        },

        getkoltsegvetes: function() {
            return {
                osszeg: adat.koltsegvetes,
                bev: adat.osszegek.bev,
                kia: adat.osszegek.kia,
                szazalek: adat.szazalek
            }
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
                html = '<div class="tetel clearfix" id="bev-0"> <div class="tetel__leiras">Fizetés</div> <div class="right clearfix"> <div class="tetel__ertek">+ 2,100.00</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>'
            } else if (tipus === 'kia') {
                elem = DOM_elemek.kiadasTarolo;
                html = '<div class="tetel clearfix" id="kia-0"> <div class="tetel__leiras">Lakás bérleti díj</div> <div class="right clearfix"> <div class="tetel__ertek">- 900.00</div> <div class="tetel__szazalek">21%</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>'
            }

            // HTML string placeholder cseréje értékekkel
            ujHtml = html.replace('%id%', obj.id);
            ujHtml = ujHtml.replace('%leiras%', obj.leiras);
            ujHtml = ujHtml.replace('%ertek%', obj.ertek);

            // HTML beszúrása a DOM-ba
            document.querySelector(elem).insertAdjacentHTML('beforeend', ujHtml);
        },

        urlapTorles: function() {
            var mezok, mezokTomb;
            mezok = document.querySelectorAll(DOM_elemek.inputLeiras + ', ' + DOM_elemek.inputErtek);
            mezokTomb = Array.prototype.slice.call(mezok);

            mezokTomb.forEach(function(currentvalue, index, array) {
                currentvalue.value = '';
            });
            mezokTomb[0].focus();
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

    var osszegFrissitese = function() {
        // 1. Költségvetés újraszámolása
        koltsegvetesVezerlo.koltsegvetesSzamolas();

        // 2. Összeg visszaadása
        var koltsegvetes = koltsegvetesVezerlo.getkoltsegvetes();

        // 3. Összeg megjelenítése a felületen
        console.log(koltsegvetes);
    }
    
    var vezTetelHozzaadas = function() {
        var input, ujTetel;
        
        // 1. bevitt adatok megszerzése
        input = feluletVezerlo.getInput();
        if (input.leiras !== '' && !isNaN(input.ertek) && input.ertek > 0) {
            // 2. adatok átadása a koltsegvetesVezerlo modulnak
            ujTetel = koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);
        
            // 3. Megjelenítés UI-n
            feluletVezerlo.tetelMegjelenites(ujTetel, input.tipus);

            // 4. Mezők törlése
            feluletVezerlo.urlapTorles();

            // 5. Költségvetés újraszámolása és frissítése a felületen
            osszegFrissitese();
        }
    }
    return {
        init: function() {
            console.log("Alkalmazás fut");
            esemenykezelokBeallit();
        }
    }

})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();