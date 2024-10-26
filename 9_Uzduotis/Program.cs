
class Program
{
    static void Main(string[] args)
    {
        Studentas studentas = new Studentas();
        studentas.amzius = 20;
        studentas.vidurkis = 6;
        studentas.pazymiuKiekis = 2;
        studentas.vardas = "tomas";
        studentas.pavarde = "tomauskas";
    }
}

class Studentas
{
    public int amzius = 0, pazymiuKiekis=0;
    public double vidurkis = 0;
    public string vardas = "", pavarde = "";

    public void pridetiPazymi(double pazymys)
    {
        double vid = ((vidurkis * pazymiuKiekis) + pazymys) / (pazymiuKiekis + 1);
    }

    public bool arPraejoISekanciaKlase()
    {
        return vidurkis>=5?true:false;
    }

}