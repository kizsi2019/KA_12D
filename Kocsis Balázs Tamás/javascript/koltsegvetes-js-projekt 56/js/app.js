//Koltsegvetesvezerlo
var koltsegvetesVezerlo = (function(){
    var Kiadas = function(id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = parseInt(ertek);
    }
    var Bevetel = function(id, leiras, ertek){
        this.id = id;
        this.leiras = leiras;
        this.ertek = parseInt(ertek);
    }

    var vegosszegSzamolas = function(tip){
        var osszeg = 0;
        if(adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0){
            adat.tetelek[tip].forEach(function(currentValue){
                if(!isNaN(currentValue.ertek)){
                    osszeg += currentValue.ertek;
                }
            });
            adat.osszegek[tip] = osszeg;
        }
    }

    var adat = {
        tetelek: {
            bev: [{id: 0}],
            kia: [{id: 0}]
        },
        osszegek: {
            kia: 0,
            bev: 0
        },
        koltsegvetes: 0,
        szazalek: -1
    }

    return {
        tetelHozzaad: function(tip, lei, ert){
            var ujTetel, ID;
            ID = 0;

            // ID letrehozasa
            if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0){
                ID = adat.tetelek[tip][adat.tetelek[tip].length - 1].id + 1;
            }
            else{
                ID = 0;
            }

            // uj kiadas v bevetel letrehozas
            if (tip === 'bev'){
                ujTetel = new Bevetel(ID, lei, ert);
            }
            else if (tip === 'kia'){
                ujTetel = new Kiadas(ID, lei, ert)
            }
            else{
                //kezeld a hibat, pl dobjon hibat v allitsa ujTetelt null ra
                throw new Error('Invalid tip: ' + tip);
            }

            //uj tetel hozzaadasa az adatszerkezethez
            if (adat.tetelek[tip] !== undefined){
                adat.tetelek[tip].push(ujTetel);
            }

            //uj tetel visszaadasa
            return ujTetel;
        },

        koltsegvetesSzamolas: function(){

            //bevetel es kiadasok osszegenek kiszamitasa
            vegosszegSzamolas('bev');
            vegosszegSzamolas('kia');

            //koltsegvetes kiszamitasa: bevetel - kiadas
            adat.koltsegvetes = adat.osszegek.bev - adat.osszegek.kia;

            //szazalak szamolasa: kiadas / bevetel * 100
            if (adat.osszegek.bev > 0){
                adat.szazalek = Math.round((adat.osszegek.kia / adat.osszegek.bev) * 100);
            }
            else{
                adat.szazalek = -1;
            }

        },
         getkoltsegvetes: function(){
            return{
                osszeg: adat.koltsegvetes,
                bev: adat.osszegek.bev,
                kia: adat.osszegek.kia,
                szazalek: adat.szazalek
            }
        },

        teszt: function(){
            console.log(adat);
        }
    }
    
})();
//feluletvezerlo
var feluletVezerlo = (function(){

    var DOMElemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb',
        bevetelTarolo: '.bevetelek__lista',
        kiadasTarolo: '.kiadasok__lista',
        koltsegvetesCimke: '.koltsegvetes__ertek',
        osszbevetelCimke: '.koltsegvetes__bevetelek--ertek',
        osszkiadasCimke: '.koltsegvetes__kiadasok--ertek',
        szazalekCimke: '.koltsegvetes__kiadasok--szazalek'
    };

    return {
        getInput: function(){
            return {
                tipus: document.querySelector(DOMElemek.inputTipus).value,
                leiras: document.querySelector(DOMElemek.inputLeiras).value,
                ertek: document.querySelector(DOMElemek.inputErtek).value
            }
        },
        getDOMElemek: function(){
            return DOMElemek;
        },

        tetelMegjelenites: function(obj, tipus){
            var html, ujHtml, elem;

            //HTML string letrehozasa placeholder ertekekkel
            if(tipus === 'bev'){
                elem = DOMElemek.bevetelTarolo;
                html = '<div class="tetel clearfix" id="bev-%id%"><div class="tetel__leiras">%leiras%</div><div class="right clearfix"><div class="tetel__ertek">%ertek%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            }
            else if(tipus === 'kia'){
                elem = DOMElemek.kiadasTarolo;
                html = '<div class="tetel clearfix" id="kia-%id%"><div class="tetel__leiras">%leiras%</div><div class="right clearfix"><div class="tetel__ertek">%ertek%</div><div class="tetel__szazalek">21%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
            }

            //HTML string placeholder értékekkel cseréje
            ujHtml = html.replace('%id%', obj.id);
            ujHtml = ujHtml.replace('%leiras%', obj.leiras);
            ujHtml = ujHtml.replace('%ertek%', obj.ertek);

            //HTML beszúrása a DOM-ba
            document.querySelector(elem).insertAdjacentHTML('beforeend', ujHtml);
        },
        urlapTorles: function(){
            var mezok, mezokTomb;
            mezok = document.querySelectorAll(DOMElemek.inputLeiras + ', ' + DOMElemek.inputErtek);
            mezokTomb = Array.prototype.slice.call(mezok);

            mezokTomb.forEach(function(currentValue, index, array){
                currentValue.value = '';
            });
            mezokTomb[0].focus();
        },

        koltsegvetesMegjelenites: function(obj){
            document.querySelector(DOMElemek.koltsegvetesCimke).textContent = obj.osszeg;
            document.querySelector(DOMElemek.osszbevetelCimke).textContent = obj.bev;
            document.querySelector(DOMElemek.osszkiadasCimke).textContent = obj.kia;

            if(obj.szazalek > 0){
                document.querySelector(DOMElemek.szazalekCimke).textContent = obj.szazalek + '%';
            }
            else{
                document.querySelector(DOMElemek.szazalekCimke).textContent = '---';
            }
        }
    };
})();

// alkalmazasvezerlo
var vezerlo = (function(koltsegvetesVezerlo, feluletVezerlo){
    
    var esemenykezeloBeallit = function(){
        var DOM = feluletVezerlo.getDOMElemek();

        document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzaadas);

        document.addEventListener('keydown', function(event){
            if (event.key !== undefined && event.key === 'Enter') {
                vezTetelHozzaadas();
            }
            else if (event.keyCode !== undefined && event.keyCode === 13) {
                vezTetelHozzaadas();
            }
        });
    };

    var osszegFrissitese = function(){
        
        koltsegvetesVezerlo.koltsegvetesSzamolas();

        var koltsegvetes = koltsegvetesVezerlo.getkoltsegvetes();

        console.log(koltsegvetes);
    }
    vezTetelHozzaadas = function() {
        
        var input, ujTetel;
        
        // bevitt adatok megszerzese
        
        input = feluletVezerlo.getInput();

        ujTetel = koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        feluletVezerlo.tetelMegjelenites(ujTetel, input.tipus);

        feluletVezerlo.urlapTorles();

        osszegFrissitese();
    };

    return {
        init: function() {
            console.log('Alkalmazás fut');
            feluletVezerlo.koltsegvetesMegjelenites({
                osszeg: 0,
                bev: 0,
                kia: 0,
                szazalek: -1
            });
            esemenykezeloBeallit();
        }
    }
})(koltsegvetesVezerlo, feluletVezerlo)


vezerlo.init();
