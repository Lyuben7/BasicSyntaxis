namespace Exercise17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double units = double.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());

            double bill = units * rate + 10;
            Console.WriteLine($"{bill:F2}");
        }
    }
}