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
         else{
            throw new Error('Invalid tip ' + tip);
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
      inputGomb: '.hozzaad__gomb',
      bevetelTarolo: '.bevetelek__lista',
      kiadasTarolo: '.kiadasok__lista'
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
   },

   tetelMegjelenítés: function(obj, tipus){
      var html, ujHtml, elem;
      
      //HTML string létrehozása
      if (tipus ===  "bev"){
         elem = DOMElemek.bevetelTarolo;
         html = '<div class="tetel clearfix" id="bevetelek-0"> <div class="tetel__leiras">Fizetés</div> <div class="right clearfix"> <div class="tetel__ertek">+ 2,100.00</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button> </div> </div> </div> <div class="tetel clearfix" id="bevetelek-1"> <div class="tetel__leiras">Autó eladás</div> <div class="right clearfix"> <div class="tetel__ertek">+ 1,500.00</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button> </div> </div> </div>'
      }
      else if (tipus === "kia"){
         elem = DOMElemek.kiadasTarolo;
         html = '<div class="tetel clearfix" id="bevetelek-0"> <div class="tetel__leiras">Fizetés</div> <div class="right clearfix"> <div class="tetel__ertek">+ 2,100.00</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button> </div> </div> </div> <div class="tetel clearfix" id="bevetelek-1"> <div class="tetel__leiras">Autó eladás</div> <div class="right clearfix"> <div class="tetel__ertek">+ 1,500.00</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button> </div> </div> </div>'
      }

      ujHtml = html.replace('°%id%', obj.id);
      ujHtml = ujHtml.replace('%leiras%', obj.leiras);
      ujHtml = ujHtml.replace('%ertek%', obj.ertek);

      // HTML beszúrása a DOM-ba
      document.querySelector(elem).insertAdjacentHTML('beforeend', ujHtml);
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
      input = feluletVezerlo.getInput();

    //2. adatok átadása a koltsegvetesVezerlo modulnak
    ujTetel = koltsegvetesVezerlo.tetelHozzaad(input.tipus, input.leiras, input.ertek);
   
    //3. Megjelenítés UI-n
    feluletVezerlo.tetelMegjelenítés(ujTetel, input.tipus);

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