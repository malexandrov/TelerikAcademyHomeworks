using System;

class MaximalSumMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for (int row = 0; row < n; row++)                           // Populate matrix
        {
            for (int col = 0; col < m ; col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        PrintMatrix(matrix);                                        // Print matrix

        for (int row = 0; row < n-2; row++)                         // Populate matrix
        {
            for (int col = 0; col < m-2; col++)
            {
               int sum = matrix[row , col] + matrix[row , col+1] + matrix[row , col+2] +
                         matrix[row+1,col] + matrix[row+1,col+1] + matrix[row+1,col+2] +
                         matrix[row+2,col] + matrix[row+2,col+1] + matrix[row+2,col+2] ;
               if (sum > maxSum)
               {
                   maxSum = sum;
                   maxRow = row;
                   maxCol = col;
               }
            }
        }

        Console.WriteLine();
        Console.WriteLine("The best sum is " + maxSum + " in this platform:");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write("{0,3}", matrix[maxRow + row, maxCol + col]);
            }
            Console.WriteLine();
        }

    }

    private static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
