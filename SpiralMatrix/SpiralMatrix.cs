using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Insert a positive int 1<= N <=20: ");
        int size = int.Parse(Console.ReadLine());
        int direction = 0;
        int top = 0;
        int bottom = size - 1;
        int left = 0;
        int right = size - 1;
        int filler = 1;
        int[,] matrix = new int[size, size];

        while (top <= bottom && left <= right)
        {
            if (direction == 0)
            {
                for (int i = left; i <= right; i++)
                {
                    matrix[top, i] = filler++;
                }

                top++;
            }
            else if (direction == 1)
            {
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i, right] = filler++;
                }

                right--;
            }
            else if (direction == 2)
            {
                for (int i = right; i >= left; i--)
                {
                    matrix[bottom, i] = filler++;
                }

                bottom--;
            }
            else if (direction == 3)
            {
                for (int i = bottom; i >= top; i--)
                {
                    matrix[i, left] = filler++;
                }

                left++;
            }

            direction++;
            direction %= 4;
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("{0,-4}", matrix[i, j]);
            }

            Console.WriteLine();
        }
    }
}