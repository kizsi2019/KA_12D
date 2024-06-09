function receptLekerdez(){
    setTimeout(() =>{
        const receptID = [676, 102, 34, 1489, 321];
        console.log(receptID)

        setTimeout((id) =>{
            const recept = {
                cim: "Gulyás leves",
                kategoria: "Levesek"
            }
            console.log(`${id}: ${recept.cim}`);

            setTimeout(kategoria =>{
                const levesek = [{cim: "Nyírségi gombócleves", kategoria:"Levesek"}, 
                                {cim:"Borsóleves", kategoria: "levesek"}];
                console.log(levesek);
            }, 2000, recept.kategoria);
        }, 2000, receptID[1])
    }, 3000)
}

receptLekerdez();