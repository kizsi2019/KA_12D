var teszt = 10;
console.log(teszt);
console.log(window.teszt);
console.log(window["teszt"]);

function egy(){
    console.log(teszt);
}

egy();
window.egy();