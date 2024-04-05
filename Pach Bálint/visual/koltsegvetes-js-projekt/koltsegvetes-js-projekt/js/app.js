// Költségvetés vezérlő
var koltsegvetesVezerlo = (function(){

})();

// Felület vezérlő
var feluletVezerlo = (function(){

    var DOMElemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb'
    }
    return {
        getInput: function() { 
            return {
                tipus: document.querySelector(DOMElemek.inputTipus).value,
                leiras: document.querySelector(DOMElemek.inputLeiras).value,
                ertek: document.querySelector(DOMElemek.inputErtek).value,
            }
        },

    
        
    getDOMElemek: function(){
        return DOMElemek;

    }
}

})();
 
      
var vezerlo = (function(koltsegvetesVez, feluletVez){

    document.querySelector(".hozzaad__gomb").addEventListener('click', function(){
        // 1. bevitt adatok megszerzése
        var input = feluletVezerlo.getInput();
        console.log(input);

        // 2. adatok átadása a koltsegvetesVezerlo modulnak

        // 3. Megjelenítés UI-n

        // 4. Költségvetés újraszámolása

        // 5. Összeg megjelenítése a felületen
});

document.addEventListener('keydown', function(event){
    if (event.key !== undefined && event.key === 'Enter') {
        vezTetelHozzaadas();
    } else if (event.keyCode !== undefined && event.keyCode === 13) {
        vezTetelHozzaadas();
    }
         
    
})

})(koltsegvetesVezerlo, feluletVezerlo);

