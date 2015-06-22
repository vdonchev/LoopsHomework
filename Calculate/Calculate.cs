using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Insert two integer numbers n and x, each on a separate line:");
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        double factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            double divider = Math.Pow(x, i);
            sum += factorial / divider;
        }

        Console.WriteLine("{0:F5}", sum);
    }
}