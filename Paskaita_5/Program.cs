

Filmas filmas = new Filmas("Drakula", 9,new DateTime(2008, 10, 10));
Filmas BadoZaidynes = new Serialas("Bado Zaidynes", 9, new DateTime(2010, 09, 10),5);


Console.WriteLine(BadoZaidynes.GaukKiekPavadinimeRaidziu());
//Console.WriteLine(filmas.GaukKiekPavadinimeRaidziu());
//Console.WriteLine(BadoZaidynes.GaukKiekPavadinimeRaidziu());

List<Filmas> Filmai = new List<Filmas>();

foreach (Filmas film in Filmai)
{
    Console.WriteLine(film.Pavadinimas);
}




class Serialas : Filmas
{
    public Serialas(string pavadinimas, int ivertinimas, DateTime data, int serijuKiekis)
    {
        Filmas filmukas = new Filmas(pavadinimas, ivertinimas, data);
        SerijuKiekis = serijuKiekis;

    }
    public int SerijuKiekis { get; set; }
}



class Filmas
{
    public Filmas(string pavadinimas, int ivertinimas, DateTime data)
    {
        Pavadinimas = pavadinimas;
        Ivertinimas = ivertinimas;
        SukurimoData = data;
    }
    public string Pavadinimas { get; private set; }
    public int Ivertinimas { get; private set; }
    public DateTime SukurimoData { get; private set; }

    public int GaukKiekPavadinimeRaidziu()
    {
        int kiekis = Pavadinimas.Length;
        return kiekis;
    }
}