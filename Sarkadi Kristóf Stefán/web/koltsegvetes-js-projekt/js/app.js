//költségvetés vezérlő
var koltsegvetesVezerlo = (function(){
    
})();

//felület vezérlő
var feluletVezerlo = (function() {

})();

//alkalmazás vezérlő
var vezerlo = (function(koltsegvetesVez, feluletVez) {
    document.querySelector('.hozzaad__gomb').addEventListener('click', function(){
        //1. bevitt adatok bevitele


        //2. adatok átadása


        //3. megjelenítés


        //4. költségvetés újra számolása


        //5. összeg megjelenítése
    });
    document.addEventListener('keydown', function(event){
        if (event.keyCode === 13){
            console.log('enter');
        }
    });
})(koltsegvetesVezerlo, feluletVezerlo);

