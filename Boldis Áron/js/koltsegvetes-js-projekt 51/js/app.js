var koltsegvetesVezerlo = (function(){
   var Kiadas = function(id, leiras, ertek){
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
         bev: [{ id:0 }],
         kia: [{ id:0 }]
      },
      osszegek: {
         bev: 0,
         kia: 0
      }
   }

   return {
      tetelHozzaad: function(tip, lei, ert){
         var ujTetel, ID;
         ID = 0;

         //ID létrehozása
         if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0){
            ID = adat.tetelek[tip][adat.tetelek[tip].length - 1].id + 1;
         }
         else{
            ID = 0;
         }

         //Új kiadás vagy bevétel létrhozása
         if (tip === "bev"){
            ujTetel = new Bevetel(ID, lei, ert);
         }
         else if (tip === "kia"){
            ujTetel = new Kiadas(ID, lei, ert);
         }

         //Új tétel hozzáadása az adatszerkezethez
         if (adat.tetelek[tip] !== undefined){
            adat.tetelek[tip].push(ujTetel);
         }

         //új tétel hozzáadása
         return ujTetel;
      },

      teszt: function(){
         console.log(adat);
      }
   }
   
})();

var feluletVezerlo = (function(){

   var DOMElemek = {
      inputTipus: '.hozzaad__tipus',
      inputLeiras: '.hozzaad__leiras',
      inputErtek: '.hozzaad__ertek',
      inputGomb: '.hozzaad__gomb'
   }
   return{
      getInput: function(){
         return{
            tipus: document.querySelector(DOMElemek.inputTipus).value,
            leiras: document.querySelector(DOMElemek.inputLeiras).value,
            ertek: document.querySelector(DOMElemek.inputErtek).value,
         }
      },
   
   getDOMEelemek: function(){
      return DOMElemek;
   }
   }
})();


var vezerlo = (function(koltsegvetesVez, feluletVez){
   var esemenykezelokBeallit = function(){
      var DOM = feluletVezerlo.getDOMEelemek();
      document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzadas);
      
   }
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
   return {
      init: function(){
         console.log("Alkalmazás fut");
         esemenykezelokBeallit();
      }
   }
   

   document.querySelectorAll(DOM.inputGomb).addEventListener("click", vezTetelHozzadas);

   document.addEventListener("keydown", function(event){
      if (event.key !== undefined && event.key === "Enter" ){
         vezTetelHozzadas();
      }else if (event.keyCode !== undefined && event.keyCode === 13){
         vezTetelHozzadas();
      }
   });

})(koltsegvetesVezerlo, feluletVezerlo);

vezerlo.init();

