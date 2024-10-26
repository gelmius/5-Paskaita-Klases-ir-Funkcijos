
internal class Program
{
    public static void NelyginiuSkaiciuSuma(int riba)
    {
        int suma = 0;
        for (int i = riba; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite skaiciu");
        int temp = int.Parse(Console.ReadLine());
        NelyginiuSkaiciuSuma(temp);
    }
}