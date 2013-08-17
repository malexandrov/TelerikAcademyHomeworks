using System;
using System.Collections.Generic;

class Labyrinth
{
    static char[,] maze = {{' ',' ',' ','*',' ',' ',' '},
                           {'*','*',' ','*',' ','*',' '},
                           {' ',' ',' ',' ',' ',' ',' '},
                           {' ','*','*','*','*','*',' '},
                           {' ',' ',' ',' ',' ',' ','e'}};
    static List<string> path = new List<string>();

    static void Main()
    {

        Move(0, 0);
    }

    private static void Move(int x, int y)
    {
        if ((x < 0) || (y < 0) || (x >= maze.GetLength(0)) || (y >= maze.GetLength(1)))
        {
            return;
        }
        if (maze[x, y] == 'e')
        {
            Console.WriteLine("Found exit!");
            PrintPath();
           // path.;
        }
        if (maze[x, y] != ' ')
        {
            return;
        }
        
        maze[x, y] = 's';  // Mark as visited
        string dvoika = "(" + x + "," + y + ")";
        path.Add(dvoika);

        Move(x, y - 1);  // Left
        Move(x - 1, y);  // Up
        Move(x + 1, y);  // Down
        Move(x, y + 1);  // Right
       
        maze[x, y] = ' ';  // Zachistvaning
        path.RemoveAt(path.Count - 1);
    }

    private static void PrintPath()
    {
        for (int i = 0; i < path.Count; i++)
        {
            Console.Write(path[i]);
        }
        Console.WriteLine();
    }
}