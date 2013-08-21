namespace EigthQueensProblem
{
    using System;
    using System.Collections.Generic;

    class EightQueensProblem
    {
        static void Main(string[] args)
        {
            int size = 8;
            EightQueensSolver(new bool[size, size], new int[size, size], 0);
        }

        static void EightQueensSolver(bool[,] board, int[,] occupied, int columnIndex)
        {
            if (columnIndex == board.GetLength(0))
            {
                PrintSolution(board);
                return;
            }

            for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
            {
                if (occupied[rowIndex, columnIndex] == 0)
                {
                    board[rowIndex, columnIndex] = true;
                    MarkBoard(occupied, +1, rowIndex, columnIndex);
                    EightQueensSolver(board, occupied, columnIndex + 1);
                    board[rowIndex, columnIndex] = false;
                    MarkBoard(occupied, -1, rowIndex, columnIndex);
                }
            }
        }

        private static void PrintSolution(bool[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (board[i, j] == true)
                    {
                        Console.Write(" Q ");
                    }
                    else
                    {
                        Console.Write(" X ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void MarkBoard(int[,] occupied, int value, int row, int column)
        {
            for (int i = 0; i < occupied.GetLength(0); i++)
            {
                occupied[i, column] += value;
                occupied[row, i] += value;

                if (column + i < occupied.GetLength(0) && row + i < occupied.GetLength(0))
                {
                    occupied[row + i, column + i] += value;
                }
                if (column + i < occupied.GetLength(0) && row - i >= 0)
                {
                    occupied[row - i, column + i] += value;
                }
            }
        }
    }
}
