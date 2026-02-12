namespace NedelinSyntaxis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double c = 2 * Math.PI * r;

            Console.WriteLine($"{c:F2}");
        }
    }
}