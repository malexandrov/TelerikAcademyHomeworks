using System;

class PrintSpiralMatrix
{
    static void Main()
    {
        int n;
        string consoleInput;

        do
        {
            Console.Write("Please enter N < 20: ");
        }
        while (!int.TryParse(consoleInput = Console.ReadLine(), out n) || n < 0 || n > 20);

        int[,] array = new int[n, n];
        int direction = 0;
        int row = 0, col = 0;

        for (int count = 1; count <= n * n; count++)
        {
            array[row, col] = count;

            if (direction == 0)
            {
                if (col + 1 >= n)
                {
                    direction = 1;
                    row++;
                }
                else if (array[row, col + 1] != 0)
                {
                    direction = 1;
                    row++;
                }
                else
                {
                    col++;
                }
            }
            else if (direction == 1)
            {
                if (row + 1 >= n)
                {
                    direction = 2;
                    col--;
                }
                else if (array[row + 1, col] != 0)
                {
                    direction = 2;
                    col--;
                }
                else
                {
                    row++;
                }
            }
            else if (direction == 2)
            {
                if (col - 1 < 0)
                {
                    direction = 3;
                    row--;
                }
                else if (array[row, col - 1] != 0)
                {
                    direction = 3;
                    row--;
                }
                else
                {
                    col--;
                }
            }
            else if (direction == 3)
            {
                if (row - 1 < 0)
                {
                    direction = 0;
                    col++;
                }
                else if (array[row - 1, col] != 0)
                {
                    direction = 0;
                    col++;
                }
                else
                {
                    row--;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}