﻿namespace _09.LargestConnectedArea
{
    using System;
    using System.Collections.Generic;

    class LargestConnectedArea
    {
        static List<Tuple<int, int>> path;
        static char[,] labyrinth =
        {
            {' ', ' ', ' ', '#', ' ', '#' ,' '},
            {' ', ' ', ' ', ' ', '#', '#' ,' '},
            {' ', ' ', ' ', '#', ' ', '#' ,' '},
            {'#', '#', '#', '#', '#', '#' ,' '},
            {' ', ' ', ' ', ' ', ' ', '#' ,' '},
            {' ', '#', ' ', '#', ' ', '#' ,'#'},
            {' ', ' ', ' ', ' ', ' ', '#' ,'#'},
            {' ', '#', ' ', '#', ' ', '#' ,' '},
            {' ', ' ', ' ', ' ', ' ', '#' ,' '},
        };

        private static void Main(string[] args)
        {
            List<Tuple<int, int>> maxPath = new List<Tuple<int,int>>();

            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    if (labyrinth[row,col] == ' ')
                    {
                        path = new List<Tuple<int, int>>();

                        FindAllPaths(row, col);

                        if (path.Count > maxPath.Count)
                        {
                            maxPath = path;
                        }
                    } 
                }
            }

            PrintMatrix(labyrinth);
            Console.WriteLine();
            Console.WriteLine("Largest area of adjacent cells: " + maxPath.Count);
        }

        private static void FindAllPaths(int row, int col)
        {
            if ((row < 0) || (col < 0) || (row >= labyrinth.GetLength(0)) || (col >= labyrinth.GetLength(1)))
            {
                return;
            }
            
            if (labyrinth[row, col] != ' ')
            {
                return;
            }

            path.Add(new Tuple<int, int>(row, col));
            labyrinth[row, col] = 'o';

            FindAllPaths(row, col - 1); //left
            FindAllPaths(row - 1, col); //up
            FindAllPaths(row, col + 1); //right
            FindAllPaths(row + 1, col); //down
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
