using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Positive integer number n (1 <= n <= 20): ");
        int num = int.Parse(Console.ReadLine());

        for (int row = 0; row < num; row++)
        {
            for (int col = 1; col <= num; col++)
            {
                Console.Write("{0, -3}", row + col);
            }
            Console.WriteLine();
        }
    }
}