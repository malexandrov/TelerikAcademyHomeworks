namespace FindIfPathExists
{
      using System;
    using System.Collections.Generic;

    public class FindPathInLabyrinth
    {
        private static void Main(string[] args)
        {
            char[,] labyrinth = new char[100,100];
            
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    labyrinth[i, j] = ' ';
                }
            }

            labyrinth[99, 99] = 'e';

            labyrinth[98, 98] = '#';
            labyrinth[99, 98] = '#';
            labyrinth[98, 99] = '#';
            bool foundExit = false;
            FindPath(labyrinth, 0, 0, ref foundExit);

            Console.WriteLine("Found path? " + foundExit);
        }

        private static void FindPath(char[,] labyrinth, int row, int col, ref bool found)
        {
            if ((row < 0) || (col < 0) || (row >= labyrinth.GetLength(0)) || (col >= labyrinth.GetLength(1)))
            {
                return;
            }

            if (labyrinth[row, col] == 'e')
            {
                Console.WriteLine("Path found");
                found = true;
                Environment.Exit(0);
            }

            if (labyrinth[row, col] != ' ')
            {
                return;
            }
            labyrinth[row, col] = 's';

            FindPath(labyrinth, row, col - 1, ref found); //left
            FindPath(labyrinth, row + 1, col, ref found); //down
            FindPath(labyrinth, row - 1, col, ref found); //up
            FindPath(labyrinth, row, col + 1, ref found); //right

           labyrinth[row,col] = ' ';
        }
    }
}
