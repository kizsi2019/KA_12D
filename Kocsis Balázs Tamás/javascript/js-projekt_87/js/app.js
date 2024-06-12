/*
const masodik = () =>{
    console.log('masodik')
};

const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
};

elso();


const masodik = () =>{
    setTimeout(() =>{
        console.log('Asszinkron masodik')
    }, 6000);
    
};

const elso = () => {
    console.log('elso')
    masodik();
    console.log('harmadik')
};

elso();


//////////////////////callback hell////////////////////////////////////////////////////////////////

function receptLekerdez(){
    setTimeout(() => {
        const receptID = [676, 102, 34, 1489, 321]
        console.log(receptID)

        setTimeout((id) => {
            const recept = {
                cim: 'Gulyas',
                kategoria: 'Levesek'
            }
            console.log(`${id}. ${recept.cim}`);

            setTimeout(kategoria => {
                const levesek = [
                    {cim: 'nyirsegi gombocleves', kategoria: 'Levesek'},
                    {cim: 'borsoleves', kategoria: 'Levesek'}
                ];

                console.log(levesek);
            }, 2000, recept.kategoria);
        }, 2000, receptID[1])
    }, 3000)
}

receptLekerdez();

//////////////////////////promise////////////////////////////////////////////////////////////////

const azonositokLekerdezese = new Promise((resolve, reject) => {
    setTimeout(() => {
        resolve([676, 102, 34, 1489, 321]);
    }, 2000);
});

const receptLekeres = (receptID) => {
    return new Promise((resolve, reject) => {
        setTimeout((id) => {
            const recept = {
                cim: 'Gulyas',
                kategoria: 'Levesek'
            };
            resolve(`${id}. ${recept.cim}`);
        }, 2000, receptID);
    });
};

const kategoriaLekeres = (kategoria) => {
    return new Promise((resolve, reject) => {
        setTimeout((kat) => {
            const levesek = [
                {cim: 'tokleves', kategoria: 'Levesek'},
                {cim: 'husleves', kategoria: 'Levesek'}
            ];
            resolve(levesek);
        }, 2000, kategoria)
    });
};

azonositokLekerdezese.then(azonositok => {
        console.log(azonositok);
        return receptLekeres(azonositok[2]);
    })
    .then((recept) => {
        console.log(recept);
        return kategoriaLekeres(recept.kategoria);
    })
    .then((kategoria) => {
        console.log(kategoria);
    })
    .catch(hiba => {
        console.log(hiba);
    })
*/

async function getReceptek(){
    const azonositok = await azonositokLekerdezese;
    console.log(azonositok);

    const recept = await receptLekeres(azonositok[2]);
    console.log(recept);

    const tovabbiak = await kategoriaLekeres(recept.kategoria);
    console.log(tovabbiak)

    return recept;
}
getReceptek().then(eredmeny => console.log(`${eredmeny} a legjobb leves!!!!!!!!!!!!`))












