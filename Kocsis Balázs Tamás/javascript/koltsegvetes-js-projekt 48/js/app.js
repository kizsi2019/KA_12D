//Koltsegvetesvezerlo
var koltsegvetesVezerlo = (function(){
    
})();
//feluletvezerlo
var feluletVezerlo = (function(){

    var DOMElemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb'
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
        }
    }

})();

// alkalmazasvezerlo
var vezerlo = (function(koltsegvetesVez, feluletVez){

    var DOM = feluletVezerlo.getDOMElemek();

    vezTetelHozzaadas = function() {
        // bevitt adatok megszerzese
        var input = feluletVezerlo.getInput();
        console.log(input);
    }
    document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzaadas);

    document.addEventListener('keydown', function(event){
        if (event.key !== undefined && event.key === 'Enter') {
            vezTetelHozzaadas();
        }
        else if (event.keyCode !== undefined && event.keyCode === 13) {
            vezTetelHozzaadas();
        }
    })

})(koltsegvetesVezerlo, feluletVezerlo)
