
class Program
{
    static void Main(string[] args)
    {

    }
}

class Knyga
{
    public int puslapiuSkaicius = 0, pazymiuKiekis = 0;
    public bool perskaityta = false;
    public string pavadinimas = "", autorius = "";

    public void perskaitytiKnyga(double pazymys)
    {
        this.perskaityta = true;
    }

    public bool arPerskaityta()
    {
        return perskaityta;
    }

    public string gautiAprasyma()
    {
        return "Autorius: " + autorius + ", Pavadinimas: " + pavadinimas + ", Puslapiu skaicius: " + puslapiuSkaicius;
    }
}