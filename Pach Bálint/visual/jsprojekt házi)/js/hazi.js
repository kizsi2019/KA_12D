const masodik = () => {

    setTimeout(() => {
        console.log('Aszinkron második');
    }, 3000);
};

const elso = () => {
    console.log('első');
    masodik();
    console.log('harmadik');
};
elso();