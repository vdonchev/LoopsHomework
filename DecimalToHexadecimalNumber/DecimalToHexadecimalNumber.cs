using System;
using System.Text;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Insert a Decimal number: ");
        long dNum = long.Parse(Console.ReadLine());
        StringBuilder hex = new StringBuilder();

        while (dNum > 0)
        {
            long curNum = dNum % 16;

            if (curNum >= 10)
            {
                hex.Insert(0, (char)(curNum + '7'));
            }
            else
            {
                hex.Insert(0, curNum);
            }

            dNum /= 16;
        }

        Console.WriteLine(hex);
    }
}