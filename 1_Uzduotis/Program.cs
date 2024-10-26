
class Program
{
    public static string ArPilnametis(int metai)
    {
        return metai >= 18 ? "Pilnametis" : "Nepilnametis";
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite metus");
        int metai = int.Parse(Console.ReadLine());
        Console.WriteLine(ArPilnametis(metai));
    }
}