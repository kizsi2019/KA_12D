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
        inputGomb: '.hozzaad__gomb'
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
        }
    }

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
vezTetelHozzaadas = function(){
    // 1. bevitt adatok megszerzese 
    var input = feluletvezerlo.getInput();
 
    
    // 2. adatok atadasa a koltsegvetesvezerlo modulnak
    
    // 3. megjelenites ui-n
    
    // 4. koltsegvetes ujraszamolasa

    // 5. osszeg megjelenitese a feluleten
}
return{
    init: function(){
        console.log('Alkalmazás fut');
        esemenykezelokBeallit();
    }
}

})(koltsegvetesvezerlo, feluletvezerlo);
vezerlo.init();



