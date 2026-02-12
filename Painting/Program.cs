namespace Painting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double totalPaint = double.Parse(Console.ReadLine());
            double paintPerRoom = totalPaint / 3;
            double red = paintPerRoom / 13;
            double yellow = red * 4;
            double white = yellow * 2;

            Console.WriteLine($"Red: {red:F4}");
            Console.WriteLine($"Yellow: {yellow:F4}");
            Console.WriteLine($"White: {white:F4}");
        }
    }
}