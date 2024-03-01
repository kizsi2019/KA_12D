//koltsegvetes Vezerlo
var koltsegvetesVezerlo = (function(){
    var a = 10
    var osszead = function(b){
        return a+b
    }
    return{
        teszt: function(x){
            return osszead(x);
        }
    }
})();
//felulet Vezerlo
var feluletVezerlo = (function(){

})();
//alkalmazás vezerlo
var vezerlo = (function(koltsegvetesVez, feluletVez){
    document.querySelector('.hozzaad__gomb').addEventListener('click', function(){
        //1.bevitt adatok megszerzése
        
        //2. adatok átadása a koltsegvetesVezerlo modulnak

        //3. megjelenités UI-n

        //4.koltségvetés ujraszámitása

        //5. összeg megjelenitése a felületen

    });
    document.addEventListener('keydown', function(event){
        if (event.keyCode === 13){
            console.log('enter');
        }
    });
})(koltsegvetesVezerlo, feluletVezerlo);