var koltsegvetesVezerlo = (function(){
   var Kiadas = function(id, leiras, ertek){
      this.id = id;
      this.leiras = leiras;
      this.ertek = ertek;
   }
   var Bevetel = function(id, leiras, ertek){
      this.id = id;
      this.leiras = leiras;
      this.ertek = parseInt(ertek);
   }

   var vegosszegSzamolas = function(tip){
      var osszeg = 0;
      if (adat.tetelek[tip] !== undefined && adat.tetelek[tip].length > 0) {
         adat.tetelek[tip].forEach(function(currentValue){
            if (!isNaN(currentValue.ertek)){
               osszeg += currentValue.ertek;
            }
         });
         adat.osszegek[tip] = osszeg; 
      }
   }

   var adat = {
      tetelek: {
         bev: [{ id:0 }],
         kia: [{ id:0 }]
      },
      osszegek: {
         bev: 0,
         kia: 0
      },
      koltsegvetes: 0,
      szazalek: -1
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

      koltsegvetesSzamolas: function(){
         vegosszegSzamolas('bev');
         vegosszegSzamolas('kia');

         adat.koltsegvetes = adat.osszegek.bev - adat.osszegek.kia;

         if (adat.osszegek.bev > 0){
            adat.szazalek = Math.round((adat.osszegek.kia / adat.osszegek.bev) * 100);
         }
         else{
            adat.szazalek = -1;
         }
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
         html = '<div class="tetel clearfix" id="bevetelek-%id%"> <div class="tetel__leiras">%leiras%</div> <div class="right clearfix"> <div class="tetel__ertek">%ertek%</div> <div class="tetel__torol"> <button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button> </div> </div> </div>';
      }
      else if (tipus === "kia"){
         elem = DOMElemek.kiadasTarolo;
         html = '<div class="tetel clearfix" id="expense-%id%"><div class="tetel__leiras">%leiras%</div><div class="right clearfix"><div class="tetel__ertek">%ertek%</div> <div class="tetel__szazalek">21%</div><div class="tetel__torol"><button class="tetel__torol--gomb"><i class="ion-ios-close-outline"></i></button></div></div></div>';
      }

      ujHtml = html.replace('°%id%', obj.id);
      ujHtml = ujHtml.replace('%leiras%', obj.leiras);
      ujHtml = ujHtml.replace('%ertek%', obj.ertek);

      // HTML beszúrása a DOM-ba
      document.querySelector(elem).insertAdjacentHTML('beforeend', ujHtml);
   },
   urlapTorles: function(){
      var mezok , mezokTomb;
      mezok = document.querySelectorAll(DOMElemek.inputLeiras + ', ' + DOMElemek.inputErtek);
      mezokTomb = Array.prototype.slice.call(mezok);

      mezokTomb = Array.prototype.slice.call(mezok);

      mezokTomb.forEach(function(currentValue, index, array){
         currentValue.value = '';
      });
      mezokTomb[0].focus();
   }
   }
})();


var vezerlo = (function(koltsegvetesVez, feluletVez){
   var esemenykezelokBeallit = function(){
      var DOM = feluletVezerlo.getDOMEelemek();
      document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzadas);
      
   }
   var osszegFrissitese = function(){
      //1. Költségvetés újraszámolása
      koltsegvetesVezerlo.koltsegvetesSzamolas();
      //2. Összeg visszaadása
      var koltsegvetes = koltsegvetesVezerlo.getKoltsegvetes();
      //3. Összeg megjelenítése a felületen
      console.log(koltsegvetes);
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
    feluletVezerlo.urlapTorles();

    //5. Össszeg megjelenítése a felületen
    osszegFrissitese();

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