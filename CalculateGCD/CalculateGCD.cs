using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Insert two integers a and b:");
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());

        // more info:
        // http://www.vcskicks.com/euclidean-gcd.php

        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a; 
            }
        }

        if (a == 0)
        {
            Console.WriteLine("GCD(a, b): " + b);
        }
        else
        {
            Console.WriteLine("GCD(a, b): " + a);
        }
    }
}