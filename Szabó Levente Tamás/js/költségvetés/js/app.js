//Koltsegvetesvezerlo
var koltsegvetesvezerlo = (function(){
    var Kiadas = function(id, leiras, ertek) {
        this.id = id;
        this.leiras = leiras;
        this.ertek = parseInt(ertek);
        this.szazalek = -1;
    }
    var Bevetel = function(id, leiras, ertek){
        this.id = id;
        this.leiras = leiras;
        this.ertek = parseInt(ertek);
    }
    Kiadas.prototype.koltsegvetesSzamolas = function(osszbevetel){
        if (osszbevetel > 0){
            this.szazalek = Math.round((this.ertek / osszbevetel)*100);
        }
        else{
            this.szazalek = -1;
        }
    };
    Kiadas.prototype.getSzazalek = function(){
        return this.szazalek;
    };
    var vegosszegSzamolas = function(tip){
        var osszeg = 0;
        if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0){
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
            bev: [{ id : 0 }],
            kia: [{ id : 0 }]
        },
        osszegek: {
            bev: 0,
            kia: 0
        },
        koltsegvetes: 0,
        szazalek: -1
    }
    return{
        tetelHozzaad: function(tip, lei, ert){
            var ujTetel, ID;
            ID = 0;
            //ID letrehozasa 
            if(adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0){
                ID = adat.tetelek[tip][adat.tetelek[tip].length - 1].id + 1;
            }
            else{
                ID = 0;
            }
            //Uj kiadas vagy bevetel letrehozas
            if(tip === 'bev') {
                ujTetel = new Bevetel(ID,lei,ert);
            }
            else if (tip === 'kia'){
                ujTetel = new Kiadas(ID,lei,ert);
            }
            else{
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
        szazalekokSzamolasa: function(){
            if (adat.osszegek.bev > 0){
                adat.tetelek.kia.forEach(function(currentValue){
                    currentValue.szazalekSzamitas(adat.osszeg.bev);
                });
            }
        },
        szazalekokLekerdezese: function(){
            var kiadasSzazalekok = adat.tetelek.kia.map(function(currentValue){
                return currentValue.getSzazalek();
            });
            return kiadasSzazalekok;
        },
        teteltorol: function(tip, id){
            var idTomb, index;
            if (adat.tetelek && adat.tetelek[tip]){
                idTomb = adat.tetelek[tip].map(function(aktualis){
                    return aktualis.id;
                });
                index = idTomb.indexOf(id);
                if (index !== -1){
                    adat.tetelek[tip].splice(index, 1);
                }
            }
            else{
                console.error('Tipus kulcs nincs itt.')
            }
        },
        koltsegvetesSzamolas: function(){
            //1. bevetel es kiadasok osszegenek kiszamitasa
            vegosszegSzamolas('bev');
            vegosszegSzamolas('kia');
            //2. szazalek szamolasa: kiadasok / bevetel * 100
            adat.koltsegvetes = adat.osszegek.bev - adat.osszegek.kia;
            //3. szazalek szamolasa: kiadasok / bevetel * 100
            if (adat.osszegek.bev > 0){
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
        kiadasTarolo: '.kiadasok__lista',
        koltsegvetesCimke: '.koltsegvetes__ertek',
        osszbevetelCimke: '.koltsegvetes__bevetelek--ertek',
        osszkiadasCimke: '.koltsegvetes__kiadasok--ertek',
        szazalekCimke: '.koltsegvetes__kiadasok--szazalek',
        kontener: '.kontener'

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
                    
            }
            else if (tipus === 'kia'){
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
        tetelTorles: function(tetelID){
            var elem = document.getElementById(tetelID);
            elem.parentNode.removeChild(elem);
        },
        urlapTorles : function(){
            var mezok, mezokTomb;
            mezok = document.querySelectorAll(DOMElemek.inputLeiras + ', ' + DOMElemek.inputErtek);
            
            mezokTomb = Array.prototype.slice.call(mezok);
            
            mezokTomb.forEach(function(currentValue, index, array){
                currentValue.value = '';
            });
            mezokTomb[0].focus();
        },
        koltsegvetesMegjelenites: function(obj) {
            document.querySelector(DOMElemek.koltsegvetesCimke).textContent = obj.osszeg;
            document.querySelector(DOMElemek.osszbevetelCimke).textContent = obj.bev;
            document.querySelector(DOMElemek.osszkiadasCimke).textContent = obj.kia;
        
            if (obj.szazalek > 0){
                document.querySelector(DOMElemek.szazalekCimke).textContent = obj.szazalek + '%';
            }
            else {
                document.querySelector(DOMElemek.szazalekCimke).textContent = '---';
            }
            }
    };
})();

// alkalmazasvezerlo
var vezerlo = (function(koltsegvetesvezerlo, feluletvezerlo){
    var esemenykezeloBeallit = function(){
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
    document.querySelector(DOM.kontener).addEventListener('click', vezTetelTorles);
    };
var osszegFrissitese = function(){
    // 1. Koltsegvetes ujraszamolasa
    koltsegvetesvezerlo.koltsegvetesSzamolas();

    // 2. Osszeg visszaadasa
    var koltsegvetes = koltsegvetesvezerlo.getkoltsegvetes();

    //3. Osszeg megjelenitese a feluleten
    feluletvezerlo.koltsegvetesMegjelenites(koltsegvetes);
};
var szazalekokFrissitese = function(){
    // 1. Százalék újraszámolás
    koltsegvetesvezerlo.szazalekokSzamolasa
    // 2. Százalék kiolvasás a költségvetés vezérlőből
    var kiadasSzazalekok = koltsegvetesvezerlo.szazalekokLekerdezese();
    // 3. Felület frissitése az új százalékkal
    console.log(kiadasSzazalekok);
}
vezTetelHozzaadas = function(){
    var input, ujTetel;
    // 1. bevitt adatok megszerzese 
    input = feluletvezerlo.getInput();
    if (input.leiras !== '' && !isNaN(input.ertek) && input.leiras > 0)
    // 2. adatok atadasa a koltsegvetesvezerlo modulnak
    ujTetel = koltsegvetesvezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);
    // 3. megjelenites ui-n
    feluletvezerlo.tetelMegjelenites(ujTetel,input.tipus);
    // 4. mezok torlese
    feluletvezerlo.urlapTorles();
    // 5. koltsegvetes ujraszamolasa
    osszegFrissitese();
    // 6. osszeg megjelenitese a feluleten
    szazalekokFrissitese();
};
var vezTetelTorles = function(event){
    //console.log(event.target.parentNode)
    var tetelID, splitID, tip, ID
    tetelID = event.target.parentNode.parentNode.parentNode.parentNode.id;
    //console.log(tetelID)
    if(tetelID){
        splitID = tetelID.split('-');
        tip = splitID[0];
        ID = parseInt(splitID[1]);
    }
    koltsegvetesvezerlo.teteltorol(tip, ID);
    feluletvezerlo.tetelTorles(tetelID);
    osszegFrissitese();
}
return{
    init: function(){
        console.log('Alkalmazás fut');
        esemenykezeloBeallit();
    }
}
})(koltsegvetesvezerlo, feluletvezerlo);
vezerlo.init();