const dobozok = document.querySelectorAll('.rectangle');
//es5

var dobozokTombES5 = Array.prototype.slice.call(dobozok)

    dobozokTombES5.forEach(function(aktualis){
        aktualis.style.backgroundColor = 'orange';
    });

//es6

const dobozokTombES6 = Array.from(dobozok);
dobozokTombES6.forEach(aktualis => aktualis.style.backgroundColor = 'blue');

//es5

for (var i = 0; i < dobozokTombES5.length; i++){
    if (dobozokTombES5[i].className === 'rectangle blue'){
        continue;
    }
    dobozokTombES5[i].textContent = 'Kék lettem';
}

//es6

for (const aktualis of dobozokTombES6){
    if (aktualis.className.includes('blue')){
        continue;
    }
    aktualis.textContent = 'Kék lettem';
}

//es5

var korok = [2, 10, 20, 17, 14]
console.log(korok);

var felnottek = korok.map(function(aktualis){
    return aktualis >= 18;
});

console.log(felnottek);

console.log(felnottek.indexOf(true));

//es6
console.log(korok.findIndex(aktualis => aktualis >= 18));
console.log(korok.find(aktualis => aktualis >= 18));