using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Positive integer n: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.Write("{0,-2}", i);
        }
        Console.WriteLine();
    }
}