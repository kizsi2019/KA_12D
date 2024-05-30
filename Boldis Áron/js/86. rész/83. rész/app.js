/*const masodik = () => {
    console.log("masodik")
};

const elso = () =>{
    console.log("elso");
    masodik();
    console.log("harmadik");
};

elso();
*/

const masodik = () => {
    setTimeout(() =>{
        console.log("Asszinkron masodik")
    }, 6000);
};

const elso = () =>{
    console.log("elso");
    masodik();
    console.log("harmadik");
};

elso();