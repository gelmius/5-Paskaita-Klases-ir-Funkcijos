
internal class Program
{
    public static void Dalikliai(int riba)
    {

        for (int i = 1; i <= riba; i++)
        {
            if (riba % i == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite skaiciu");
        int temp = int.Parse(Console.ReadLine());
        Dalikliai(temp);
    }
}