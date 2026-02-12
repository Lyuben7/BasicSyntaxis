internal class Program
{
    private static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int firstDistance = x * 5;   // 2 + 3 hours
        int secondDistance = y * 3;

        int distanceBetween = Math.Abs(firstDistance - secondDistance);

        Console.WriteLine(distanceBetween);
    }
}