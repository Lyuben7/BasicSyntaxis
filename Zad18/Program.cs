namespace Zad18
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine($"{d / t:F2}");
        }
    }
}