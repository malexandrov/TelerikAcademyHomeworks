using System;

class SortArrayOfStringsByLength
{
    static void Main()
    {
        string[] arrayOfStrings = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
        
        PrintArrayColumn(arrayOfStrings);
        SortStringArray(arrayOfStrings);
        PrintArrayColumn(arrayOfStrings);
    }

    private static void PrintArrayColumn(string[] arrayOfStrings)
    {
        for (int i = 0; i < arrayOfStrings.GetLength(0); i++)
        {
            Console.WriteLine("{0,10}", arrayOfStrings[i]);
        }
        Console.WriteLine();
    }

    private static void SortStringArray(string[] arrayOfStrings)
    {
        string tempString = null;

        for (int i = 0; i < arrayOfStrings.GetLength(0); i++)
        {
            for (int j = i; j < arrayOfStrings.GetLength(0); j++)
            {
                if (arrayOfStrings[j].Length == arrayOfStrings[i].Length)
                {
                    continue;
                }

                if (arrayOfStrings[i].Length > arrayOfStrings[j].Length)
                {
                    tempString = arrayOfStrings[i];
                    arrayOfStrings[i] = arrayOfStrings[j];
                    arrayOfStrings[j] = tempString;
                }
            }
        }
    }
}