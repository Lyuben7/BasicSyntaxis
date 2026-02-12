namespace Time
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int totalMinutes = int.Parse(Console.ReadLine());
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;
            Console.WriteLine($"{hours:D2}:{minutes:D2}");
        }
    }
}