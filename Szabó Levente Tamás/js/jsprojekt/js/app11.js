///////
//map//
///////

const kerdes = new Map();
kerdes.set('kerdes', 'Hogy hívják a tagot a de miért reklámba?');
kerdes.set(1, 'Ödön');
kerdes.set(2, 'Ábel');
kerdes.set(2, 'Józsi');
kerdes.set(2, 'Nándi');

kerdes.set('helyes', 2);

kerdes.set(true, 'Helyes válasz');
kerdes.set(false, 'Nem talált');

console.log(kerdes.get('kérdés'))
console.log(kerdes.size);

kerdes.delete(4);

kerdes.clear();

kerdes.forEach(kulcs, ertek) => console.log(`Kulcs:${kulcs}, ertek: ${ertek}`);

for (let [kulcs, ertek] of kerdes.entries()){
    if (typeof(kulcs) === 'number'){
        console.log(`Kulcs: ${kulcs}, ertek: ${ertek}`)
    }
};

const valasz = parseInt(prompt('Add meg a helyes választ!'));
console.log(kerdes.get(valasz === kerdes.get('helyes')));