
class Program
{
    static void Main(string[] args)
    {
        
    }
}

class Apskritimas
{
    public double spindulys = 0;

    public Apskritimas(double spindulys)
    {
        this.spindulys = spindulys;
    }
    public double skaiciuotiPlota()
    {
        return double.Pi * 2 * spindulys;
    }

    public double skaiciuotiPerimetra()
    {
        return double.Pi * Math.Sqrt(spindulys);
    }

}