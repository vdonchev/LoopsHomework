using System;
using System.Linq;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        Console.Write("Insert positive int > 1: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random rand = new Random();

        numbers = Enumerable.Range(1, n).OrderBy(r => rand.Next()).ToArray();

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}