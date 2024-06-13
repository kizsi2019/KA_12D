var koltsegvetesvezerlo = (function() {
    var a = 10
    var osszead = function(b){
        return a + b
    }

    return {
        teszt: function(x){
            return osszead(x);
        }
    }
})();

var feluletvezerlo = (function() {

})();

var vezerlo = (function(koltsegvetesvez, feluletvez) {
    var szam = koltsegvetesvez.teszt(2);

    return {
        vezerloTeszt: function(){
            console.log(szam);
        }
    }
})(koltsegvetesvezerlo, feluletvezerlo);

vezerlo.vezerloTeszt();

