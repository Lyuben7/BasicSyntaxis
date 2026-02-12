namespace Speed
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            double totalSeconds = (h * 3600) + (m * 60) + s;
            double speed = distance / totalSeconds;
            Console.WriteLine($"{speed:F6}");
        }
    }
}