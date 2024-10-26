
class Program
{
    static void Main(string[] args)
    {
        Automobilis automobilis = new Automobilis();
        automobilis.metai = 2010;
        automobilis.kuroLikutis = 20;
        automobilis.marke = "mb";
        automobilis.marke = "ml";

        automobilis.pildytiKura(13);
        automobilis.vaziuoti(100);
    }
}

class Automobilis
{
    public int metai = 0;
    public double kuroLikutis = 0;
    public string marke = "", modelis = "";

    public void pildytiKura(double kuras)
    {
        this.kuroLikutis += kuras;
    }

    public void vaziuoti(double atstumas)
    {
        this.kuroLikutis -= atstumas/10;
    }

}