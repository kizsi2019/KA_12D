function teglalap(a, b, funkcio)
{
    var eredmeny;
    if (funkcio === "kerulet")
    {
        eredmeny = (a+b) * 2;
    }
    else if (funkcio === "terulet")
    {
        eredmeny = a*b;
    }
    else
    {
        return "hibás funkcio!"
    }
    return funkcio + ' - ' + eredmeny;
}

console.log(teglalap(5, 4, "terulet"));
console.log(teglalap(5, 4, "kerulet"));
