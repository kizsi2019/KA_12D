async function getReceptek(){
    const azonositok = await azonositokLekerdezese;
    console.log(azonositok);
    const recept = await receptLekeres(azonositok[2]);
    console.log(recept);
    const tovabbiak = await kategoriaLekeres(recept.kategoria);
    console.log(tovabbiak)
    return recept;
}
getReceptek().then(eredmeny => console.log(`${eredmeny} a legjobb leves!`))