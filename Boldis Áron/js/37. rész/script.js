/* function jatek(){
    var pont = Math.random() * 10;
    console.log(pont  >= 5);
}

jatek(); */

/* (function(){
    var pont = Math.random() * 10;
    console.log(pont >= 5);
})(); */

(function(teszt){
    var pont = Math.random() * 10;
    console.log(pont >= 5);
    console.log(teszt);
})("Hello")