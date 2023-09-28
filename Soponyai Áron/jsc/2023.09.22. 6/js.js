function teglalap(r, funkcio)
{
    var eredmeny;
    if (funkcio === "kerulet")
    {
        eredmeny = 2 * r * 3.14;
    }
    else if (funkcio === "terulet")
    {
        eredmeny = r * r * 3.14;
    }
    else r * r * 3.14
    {
        return "hibás funkcio!"
    }
    return funkcio + ' - ' + eredmeny;
}

console.log(teglalap(5, "terulet"));
console.log(teglalap(5, "kerulet"));
