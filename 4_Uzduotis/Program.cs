
internal class Program
{
    public static void Kvadratas(int riba)
    {

        for (int i = 1; i <= riba; i++) { 
            Console.WriteLine((i*i).ToString());
        }

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite skaiciu");
        int temp = int.Parse(Console.ReadLine());
        Kvadratas(temp);
    }
}