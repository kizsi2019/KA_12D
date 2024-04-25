//Koltsegvetesvezerlo
var koltsegvetesvezerlo = (function(){
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
            bev: [{ id : 0 }],
            kia: [{ id : 0 }]
        },
        osszegek: {
            bev: 0,
            kia: 0
        }
    }
    
    return{
        tetelHozzaad: function(tip, lei, ert){
            var ujTetel, ID;
            ID = 0;

            //ID letrehozasa 
            
            if(adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0){
                ID = adat.tetelek[tip][adat.tetelek[tip].length - 1].id + 1;
            }else{
                ID = 0;
            }
            
            //Uj kiadas vagy bevetel letrehozas
            
            if(tip === 'bev') {
                ujTetel = new Bevetel(ID,lei,ert);
            }else if (tip === 'kia'){
                ujTetel = new Kiadas(ID,lei,ert);
            }else{
                //kezeld a hibat, pl dobjon hibat vagy allitsa 'ujTetel'-t 'null'-ra
                throw new Error('Invalid tip: ' + tip);
            }
            
            //uj tetel hozaadasa az adatszerkezethez
            
            if(adat.tetelek[tip] !== undefined){
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
var feluletvezerlo = (function(){
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
            return{
                tipus: document.querySelector(DOMElemek.inputTipus).value,
                leiras: document.querySelector(DOMElemek.inputLeiras).value,
                ertek: document.querySelector(DOMElemek.inputErtek).value
            }

        },
        getDOMElemek: function(){
            return DOMElemek;
        },
        tetelMegjelenites: function(obj, tipus) {
            var html,ujHtml, elem;

            //HTML string letrehozasa placeholder ertekekkel
            if (tipus === 'bev'){
                elem = DOMElemek.bevetelTarolo;
                html = ' <div class="tetel clearfix" id="bev-%id%"> <div class="tetel__leiras">%leiras%</div> <div class="right clearfix"> <div class="tetel__ertek">%ertek%</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button> </div> </div> </div>';
                    
            } else if (tipus === 'kia'){
                elem = DOMElemek.kiadasTarolo;
                html = '<div class="tetel clearfix" id="kia-%id%"> <div class="tetel__leiras">%leiras%</div> <div class="right clearfix"> <div class="tetel__ertek">%ertek%</div> <div class="tetel__szazalek">21%</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button> </div> </div> </div> ';
            }

            //HTML string placeholder ertekekkel csereje
            ujHtml = html.replace('%id%', obj.id);
            ujHtml = ujHtml.replace('%leiras%', obj.leiras);
            ujHtml = ujHtml.replace('%ertek%', obj.ertek);

            //HTML beszurasa a DOM-ba
            document.querySelector(elem).insertAdjacentHTML('beforeend', ujHtml);
        },
        urlapTorles: function(){
            var mezok, mezokTomb;
            mezok = document.querySelectorAll(DOMElemek.inputLeiras + ', ' + DOMElemek.inputErtek);
            mezokTomb = Array.prototype.slice.call(mezok);
            mezokTomb.forEach(function(currentValue, index, array){
                currentValue.value='';
            });
            mezokTomb[0].focus();
        }
    };

})();

// alkalmazasvezerlo
var vezerlo = (function(koltsegvetesvez, feluletvez){
var esemenykezelokBeallit = function(){
    var DOM = feluletvezerlo.getDOMElemek();

document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzaadas);

document.addEventListener('keydown', function(event){
    if (event.key !== undefined && event.key === 'Enter'){
        vezTetelHozzaadas();
    }
    else if (event.keyCode !== undefined && event.keyCode === 13){
        vezTetelHozzaadas();
    }

});
}
var osszegFrissites = function(){
    // 1. költségvetés ujraszámolás

    // 2. összeg visszaadás

    // 3. összeg visszaadása a feluleten

}
vezTetelHozzaadas = function(){
    var input, ujTetel;
    // 1. bevitt adatok megszerzese 
    input = feluletvezerlo.getInput();
    
    
    // 2. adatok atadasa a koltsegvetesvezerlo modulnak
    ujTetel = koltsegvetesvezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);
    // 3. megjelenites ui-n
    feluletvezerlo.tetelMegjelenites(ujTetel,input.tipus);
    //4. mezok torlese
    feluletvezerlo.urlapTorles();
    // 5. koltsegvetes ujraszamolasa
    osszegFrissites();
    // 6. osszeg megjelenitese a feluleten
}
return{
    init: function(){
        console.log('Alkalmazás fut');
        esemenykezelokBeallit();
    }
}

})(koltsegvetesvezerlo, feluletvezerlo);
vezerlo.init();



