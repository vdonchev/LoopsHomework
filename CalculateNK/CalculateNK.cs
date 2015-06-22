using System;

class CalculateNK
{
    static void Main()
    {
        Console.Write("Positive int > 0 and < 100: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Positive int > 0 and < N: ");
        double k = double.Parse(Console.ReadLine());

        double factorialN = 1;
        double factorialK = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorialK *= i;
            }
            factorialN *= i;
        }

        Console.WriteLine(factorialN / factorialK);
    }
}