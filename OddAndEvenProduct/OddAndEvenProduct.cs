using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Insert n integers given in a single line, separated by a space: ");
        string[] nums = Console.ReadLine().Split();

        int oddSum = 1;
        int evenSum = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            int currNum = int.Parse(nums[i]);

            if (i % 2 == 0)
            {
                oddSum *= currNum; // odd
            }
            else
            {
                evenSum *= currNum; // even
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddSum);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddSum);
            Console.WriteLine("even_product = {0}", evenSum);
        }
    }
}