function teglalapKeruletTerulet(a,b,funkcio){
    var eredmeny;
    if (funkcio === 'kerulet'){
        eredmeny = (a+b) * 2;
    } else if (funkcio==='terület'){
        eredmeny = a*b;
    } else {
        return 'hibas funkcio';
    }
    return funkcio+'='+ eredmeny;
}
console.log(teglalapKeruletTerulet(5,4,'kerület'));
console.log(teglalapKeruletTerulet(5,6,'terület'));
