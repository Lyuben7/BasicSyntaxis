namespace WaterConsumption
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double weekly = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            double daily = weekly / 7 / people;
            Console.WriteLine($"{daily:F2}");
        }
    }
}