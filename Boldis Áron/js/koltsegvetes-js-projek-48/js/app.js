var koltsegvetesVezerlo = (function(){
   
})();

var feluletVezerlo = (function(){

})();


var vezerlo = (function(koltsegvetesVez, feluletVez){

   document.querySelector(".hozzaad__gomb").addEventListener("click", function(){
    //1. bevitt adatok megszerzese

    //2. adatok átadása a koltsegvetesVezerlo modulnak

    //3. Megjelenítés UI-n

    //4. Költségvetés újraszámolása

    //5. Össszeg megjelenítése a felületen
   });

   document.addEventListener("keydown", function(event){
      if (event.keyCode === 13){
         console.log("enter");
      }
   });

})(koltsegvetesVezerlo, feluletVezerlo);

