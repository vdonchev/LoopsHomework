using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Positive integer n: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            Console.Write("{0} ", i);
        }

        Console.WriteLine();
    }
}