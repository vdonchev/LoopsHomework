using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Insert 3 integers: n, min and max (min <= max).");
        Console.Write("n: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max: ");
        int max = int.Parse(Console.ReadLine());

        Random rand = new Random();

        for (int i = 0; i < num; i++)
        {
            Console.Write("{0} ", rand.Next(min, max));
        }
    }
}