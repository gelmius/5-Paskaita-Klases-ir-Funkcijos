
internal class Program
{
    public static int NelyginiuSkaiciuSuma(int riba)
    {
        int suma = 0;
        for (int i = 1; i <= riba; i++)
        {
            if(i % 2 == 0)
            {
                suma += i;
            }
        }
        return suma;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Iveskite skaiciu");
        int temp = int.Parse(Console.ReadLine());
        Console.WriteLine(NelyginiuSkaiciuSuma(temp));
    }
}