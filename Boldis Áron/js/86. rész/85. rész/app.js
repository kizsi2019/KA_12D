const azonositokLekerdezese = new Promise((resolve, reject) =>{
    setTimeout(()=> {
        resolve([676, 102, 34, 1489, 321]);
        //reject("valami hiba van")
    }, 2000)
});

const receptLekeres = (receptID) =>{
    return new Promise((resolve, reject) =>{
        setTimeout((id) =>{
            const recept = {
                cim: "Gulyás leves",
                kategoria: "Levesek"
            };
            resolve(`${id}: ${recept.cim}`);
        }, 2000, receptID);
    });
};

const kategoriaLekeres = (kategoria) =>{
    return new Promise((resolve, reject) =>{
        setTimeout((kat) =>{
            const levesek = [
                {cim: "Tökleves", kategoria: "levesek"},
                {cim: "Húsleves", kategoria: "levesek"}
            ]
        }, 2000, kategoria)
    });
};

azonositokLekerdezese.then(azonositok =>{
    console.log(azonositok);
    return receptLekeres(azonositok[2]);
})
.then((recept) =>{
    console.log(recept);
    return kategoriaLekeres(recept.kategoria);
})
.then((kategoria) =>{
    console.log(kategoria);
})
.catch(hiba =>{
    console.log(hiba)
})