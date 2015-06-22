using System;

class MinMaxSumAndAverage
{
    static void Main()
    {

        // The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
        Console.WriteLine("Insert a sequence of n integer numbers:");
        Console.Write("Numbers: ");
        int nums = int.Parse(Console.ReadLine());

        if (nums < 1)
        {
            Console.WriteLine("Please insert a positive number higner than 0!");
            return;
        }

        double min = double.MaxValue;
        double max = double.MinValue;
        double sum = 0;

        for (int i = 0; i < nums; i++)
        {
            Console.Write("Num: ");
            double currNum = double.Parse(Console.ReadLine());
            
            if (currNum > max)
            {
                max = currNum;
            }

            if (currNum < min)
            {
                min = currNum;
            }

            sum += currNum;
        }

        double average = sum / nums;

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average);
    }
}