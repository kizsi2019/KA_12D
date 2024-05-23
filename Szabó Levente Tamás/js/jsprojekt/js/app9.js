//////////////////
//rest paraméter//
//////////////////

//es5

function parosVagyParatlanES5(){
    //console.log(arguments)
    var argumentTomb = Array.prototype.slice.call(arguments);
    //console.log(argumentTomb);
    argumentTomb.forEach(function(aktualisElem){
        if (aktualisElem % 2 === 0){
            console.log('Paros');
        }else{
            console.log('Paratlan');
        }
    });
}
parosVagyParatlanES5(1, 2, 3);

//es6

function parosVagyParatlanES6(...szamok){
    //console.log(szamok)
    szamok.forEach(aktualisElem => {
        if (aktualisElem % 2 === 0){
            console.log('Paros');
        }else{
            console.log('Paratlan');
        }
    });
}
parosVagyParatlanES6(1, 2, 3);

function parosVagyParatlanES5(teszt){
    var argumentTomb = Array.prototype.slice.call(arguments, 1);
    //console.log(argumentTomb);
    argumentTomb.forEach(function(aktualisElem){
        if (aktualisElem % 2 === 0){
            console.log('Paros');
        }else{
            console.log('Paratlan');
        }
    });
}
parosVagyParatlanES5('teszt', 1, 2, 3, 5, 20, 25, 100);

function parosVagyParatlanES5(teszt, ...szamok){
    //console.log(szamok)
    szamok.forEach(aktualisElem => {
        if (aktualisElem % 2 === 0){
            console.log('Paros');
        }else{
            console.log('Paratlan');
        }
    })
}
parosVagyParatlanES6('teszt', 1, 2, 3, 5, 20, 25, 100);