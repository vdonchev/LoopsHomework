using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Insert a binary number:");
        string bin = Console.ReadLine();
        long dec = 0;

        for (int i = 0, bit = bin.Length - 1; i < bin.Length; i++, bit--)
        {
            long curNum = long.Parse(bin[bit].ToString());
            dec += curNum * ((long)Math.Pow(2, i));
        }

        Console.WriteLine(dec);
    }
}