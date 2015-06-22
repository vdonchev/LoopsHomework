using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Find Nth Catalan number: ");
        double n = double.Parse(Console.ReadLine());

        double factDevision = 1;
        double factN1 = 1;
        double factN = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            factDevision *= i;

            if (i <= n + 1)
            {
                factN1 *= i;
            }

            if (i <= n)
            {
                factN *= i;
            }
        }

        double sum = factDevision / (factN1 * factN);

        Console.WriteLine("Catalan(n): {0}", sum);
    }
}
