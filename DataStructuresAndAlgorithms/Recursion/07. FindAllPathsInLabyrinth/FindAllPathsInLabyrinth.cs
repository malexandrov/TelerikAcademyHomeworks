namespace FindAllPathsInLabyrinth
{
    using System;
    using System.Collections.Generic;

    public class FindAllPathsInLabyrinth
    {
        static char[,] labyrinth =
        {
            {' ', ' ', ' ', '#', ' ', ' ' ,' '},
            {'#', '#', ' ', '#', ' ', '#' ,' '},
            {' ', ' ', ' ', ' ', ' ', ' ' ,' '},
            {' ', '#', '#', '#', '#', '#' ,' '},
            {' ', ' ', ' ', ' ', ' ', ' ' ,'e'},
        };
        static int counter = 0;
        static char[] pathLetters = new char[labyrinth.GetLength(0) * labyrinth.GetLength(1)];

        private static void Main(string[] args)
        {
            FindAllPaths(0, 0, 'S');
        }

        private static void FindAllPaths(int row, int col, char direction)
        {
            if ((row < 0) || (col < 0) || (row >= labyrinth.GetLength(0)) || (col >= labyrinth.GetLength(1)))
            {
                return;
            }

            pathLetters[counter] = direction;
            counter++;

            if (labyrinth[row,col] == 'e')
            {
                Console.WriteLine("Found path:");
                for (int i = 0; i < counter; i++)
                {
                    Console.Write(pathLetters[i]);
                }
                Console.WriteLine();
            }

            if (labyrinth[row,col] == ' ')
            {
                labyrinth[row, col] = 's';
                FindAllPaths(row, col - 1, 'L'); //left
                FindAllPaths(row - 1, col, 'U'); //up
                FindAllPaths(row, col + 1, 'R'); //right
                FindAllPaths(row + 1, col, 'D'); //down
                labyrinth[row, col] = ' ';
            }

            counter--;
        }
    }
}
