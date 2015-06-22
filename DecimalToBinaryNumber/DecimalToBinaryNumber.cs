using System;
using System.Text;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Insert a decimal number: ");
        long dNum = long.Parse(Console.ReadLine());
        StringBuilder bin = new StringBuilder();

        while (dNum > 0)
        {
            if (dNum % 2 == 0)
            {
                bin.Insert(0, 0);
            }
            else
            {
                bin.Insert(0, 1);
            }
            dNum /= 2;
        }

        Console.WriteLine(bin);
    }
}