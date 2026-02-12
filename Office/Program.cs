using System;

internal class Program
{
    private static void Main()
    {
        double first = double.Parse(Console.ReadLine());

        double second = first * 0.8;
        double third = (first + second) * 1.15;

        double total = first + second + third;

        Console.WriteLine($"{total:F3}");
    }
}