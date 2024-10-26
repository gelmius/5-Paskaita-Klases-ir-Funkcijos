
class Program
{
    static void Main(string[] args)
    {

    }
}

class BankoSaskaita
{
    public double balansas = 0;
    public string savininkoVardas = "", saskaitosNumeris = "";

    public BankoSaskaita(string savininkoVardas, string saskNr)
    {
        this.savininkoVardas = savininkoVardas;
        this.saskaitosNumeris = saskNr;
    }

    public void idetiPinigus(double suma)
    {
        balansas += suma;
    }

    public void nusiimtiPinigus(double suma)
    {
        if (balansas >= suma)
        {
            Console.WriteLine("Pavyko");
        }
        else
        {
            Console.WriteLine("Klaida");
        }
    }
    public string gautiInformacija()
    {
        return "Savininkas: " + savininkoVardas + "Balansas: " + balansas;
    }
}