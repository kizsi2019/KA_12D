function Admsfmly(kereszNev, szuletesiEv, csaladNev){
    csaladNev === undefined ? csaladNev = 'Adams' : csaladNev = csaladNev;
    this.kereszNev = kereszNev;
    this.szuletesiEv = szuletesiEv;
    this.csaladNev = csaladNev;
}
var fester = new Admsfmly('Fester', 1940);
var mortisha = new Admsfmly('Morthisa', 1965);
var kuzin = new Admsfmly('Kuzin', 1800, 'Hogyishívják');