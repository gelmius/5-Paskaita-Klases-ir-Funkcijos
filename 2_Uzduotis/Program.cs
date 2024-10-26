
internal class Program
{
    public static int Sudetis(int skaicius)
    {
        int suma = 0;
        for (int i = 1; i <= skaicius; i++)
        {
            suma += i;
        }

        return suma;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite skaiciu");
        int skaicius = int.Parse(Console.ReadLine());
        Console.WriteLine(Sudetis(skaicius));
    }
}