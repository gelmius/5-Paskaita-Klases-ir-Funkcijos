
internal class Program
{
    public static string Temperatura(int laipsniai)
    {

        switch (laipsniai)
        {
            case int laip when (laip < 0):
                return "Salta";
                break;
            case int laip when (laip >= 0 && laip <20):
                return "Vidutine";
                break;
            case int laip when (laip >= 20):
                return "Karsta";
                break;
            default:
                return "Baisiai karsta";
                break;
        }

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite skaiciu");
        int temp = int.Parse(Console.ReadLine());
        Console.WriteLine(Temperatura(temp));
    }
}