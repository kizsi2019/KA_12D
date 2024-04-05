var koltsegvetesVezerlo = (function(){
   
})();

var feluletVezerlo = (function(){

   var DOMElemek = {
      inputTipus: ".hozzad__tipus",
      inputLeiras: ".hozzaad__leiras",
      inputErtek: "hozzaad__ertek",
      inputGomb: ".hozzaad__gomb"
   }
   return{
      getInput: function(){
         return{
            tipus: document.querySelector(DOMElemek.inputTipus).value,
            leiras: document.querySelector(DOMElemek).value,
            ertek: document.querySelector(DOMElemek).value,
         }
      },
   
   getDOMEelemek: function(){
      return DOMElemek;
   }
   }
})();


var vezerlo = (function(koltsegvetesVez, feluletVez){

   var DOM = feluletVezerlo.getDOMEelemek();
   vezTetelHozzadas = function(){
      var input = feluletVezerlo.getInput();
      console.log(input);
   }
   document.querySelector(".hozzaad__gomb").addEventListener("click", function(){
    //1. bevitt adatok megszerzese
      
    //2. adatok átadása a koltsegvetesVezerlo modulnak

    //3. Megjelenítés UI-n

    //4. Költségvetés újraszámolása

    //5. Össszeg megjelenítése a felületen

   });

document.querySelectorAll(DOM.inputGomb).addEventListener("click", vezTetelHozzadas);

   document.addEventListener("keydown", function(event){
      if (event.key !== undefined && event.key === "Enter" ){
         vezTetelHozzadas();
      }else if (event.keyCode !== undefined && event.keyCode === 13){
         vezTetelHozzadas();
      }
   });

})(koltsegvetesVezerlo, feluletVezerlo);

