using System;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        int n = 5;
        int m = 4;
        string[,] arrayOfStrings = { 
                                    {"q", "w", "q" , "r", "r"},
                                    {"a", "e", "r" , "t", "y"},
                                    {"a", "r", "t" , "y", "r"},
                                    {"a", "a", "a" , "a", "s"},
                                   };
        int maxSequence = 0;
        int currentSequence = 1;
        string maxString = string.Empty;

        // Check horizontals
        for (int rows = 0; rows < m; rows++)
        {
            for (int cols = 0; cols < n-1; cols++)
            {
                if ( arrayOfStrings[rows,cols] == arrayOfStrings[rows,cols+1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    maxString = arrayOfStrings[rows, cols];
                }
            }
            currentSequence = 1;
        }
        // Check verticals
        for (int cols = 0; cols < n; cols++)
        {
            for (int rows = 0; rows < m-1 ; rows++)
            {
                if (arrayOfStrings[rows, cols] == arrayOfStrings[rows+1, cols])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    maxString = arrayOfStrings[rows, cols];
                }
            }
            currentSequence = 1;
        }
        // Check diagonals
        // To DO

        Console.WriteLine(maxSequence);
        Console.WriteLine(maxString);
     }
}
