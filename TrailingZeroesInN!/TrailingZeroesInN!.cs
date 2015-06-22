using System;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("Insert integer >= 0: ");

        ulong number = ulong.Parse(Console.ReadLine());
        ulong count = 0;


        if(number < 0)
        {
            Console.WriteLine("No factoial");
            return;
        }

        for (int i = 5; number / (ulong)i >= 1; i *= 5)
        {
            count  +=  number  /  (ulong)i;
        }

        Console.WriteLine("Trailing zeros: {0}", count);
    }
}