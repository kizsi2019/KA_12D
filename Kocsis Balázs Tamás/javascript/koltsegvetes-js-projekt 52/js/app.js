//Koltsegvetesvezerlo
var koltsegvetesVezerlo = (function(){
    var Kiadas = function(id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = ertek;
    }
    var Bevetel = function(id, leiras, ertek){
        this.id = id;
        this.leiras = leiras;
        this.ertek = ertek;
    }

    var adat = {
        tetelek: {
            bev: [{id: 0}],
            kia: [{id: 0}]
        },
        osszegek: {
            kia: 0,
            bev: 0
        }
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
        kiadasTarolo: '.kiadasok__lista'
    }
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
        }
    };

})();

// alkalmazasvezerlo
var vezerlo = (function(koltsegvetesVez, feluletVez){
    
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
    vezTetelHozzaadas = function() {
        
        var input, ujTetel;
        
        // bevitt adatok megszerzese
        
        input = feluletVezerlo.getInput();

        ujTetel = koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);

        feluletVezerlo.tetelMegjelenites(ujTetel, input.tipus);
    }
    return {
        init: function() {
            console.log('Alkalmazás fut');
                esemenykezeloBeallit();
            }
        }

})(koltsegvetesVezerlo, feluletVezerlo)


vezerlo.init();
