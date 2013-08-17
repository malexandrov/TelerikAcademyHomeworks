using System;
using System.Collections.Generic;


class FillAndPrintMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int index = 1;

        MatrixA(matrix, index);
        MatrixB(matrix, index);
        MatrixC(matrix, index);

    }

    static void MatrixA(int[,] matrix, int index)
    {
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                matrix[col, row] = index;
                index++;
            }
        }
        PrintMatrix(matrix);
    }

    static void MatrixB(int[,] matrix, int index)
    {
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    matrix[col, row] = index;
                    index++;
                }
            }
            else 
            {
                for (int col = matrix.GetLength(0) - 1; col >= 0 ; col--)
                {
                    matrix[col, row] = index;
                    index++;
                }
            }
        }
        PrintMatrix(matrix);
    }

    static void MatrixC(int[,] matrix, int index)
    {
        for (int row = 0; row < matrix.GetLength(0) ; row++)
        {
            for (int col = 0; col <= row ; col++)
            {
                matrix[matrix.GetLength(0) - row + col -1,col] = index;
                index++;
            }
        }
        for (int row = matrix.GetLength(1)-2; row >= 0 ; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                matrix[row - col, matrix.GetLength(0) - col - 1] = index;
                index++;
            }
        }
        PrintMatrix(matrix);
    }


    static void PrintMatrix(int[,] matrix)
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
