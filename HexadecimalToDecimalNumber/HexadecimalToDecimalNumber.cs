using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Insert a Hexadecimal number: ");

        string hex = Console.ReadLine();
        long dec = 0;

        for (int i = 0, bit = hex.Length - 1; i < hex.Length; i++, bit--)
        {
            long curNum;
            if ((hex[bit] - '7') >= 10)
            {
                curNum = hex[bit] - '7';
            }
            else
            {
                curNum = long.Parse(hex[bit].ToString());
            }

            dec += curNum * ((long)Math.Pow(16, i));
        }
        Console.WriteLine(dec);
    }
}