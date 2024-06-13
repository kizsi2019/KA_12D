const azonositokLekerdezese = new Promise((resolve, reject) => {
    setTimeout(() => {
       resolve([676, 102, 34, 1489, 321]);

    }, 2000);
});
const receptLekeres = (receptID) => {
    return new Promise((resolve, reject) => {
        setTimeout((id) => {
            const recept = {
                cim: 'gúlyás leves',
                kategoria:'levesek'
            };
            resolve(`${id}: ${recept.cim}`);
        }, 2000, receptID);
    });
};
const kategoriaLekeres = (kategoria) =>{
    return new Promise((resolve, reject) =>{
        setTimeout((kat) => {
            const levesek = [
                {cim:'tökleves', kategoria: 'levesek'},
                {cim:'húsleves', kategoria: 'levesek'}
            ]
        }, 2000, kategoria);
    });
};
azonositokLekerdezese.then(azonositok => {
    console.log(azonositok);return receptLekeres(azonositok[2]);
})
.then((recept)=>{
    console.log(recept);
    return kategoriaLekeres(recept.kategoria);
})
.then((kategoria)=>{
    console.log(kategoria);
})
.catch(hiba => {
    console.log(hiba);
})