using System;

class BiggerThanNeighbours
{
    static void Main()
    {
        int[] array = { 33, 11, 22, 11, 22, 11 };
        int numToCheck = int.Parse(Console.ReadLine());

        Console.WriteLine("Bigger? " + CheckNeighbours(array, numToCheck));
    }

    static bool CheckNeighbours(int[] array, int number)
    {
        bool bigger = true;

        if (number == 0)
        {
            if (array[number] < array[number + 1] )
            {
                bigger = false;
            }
        }
        if (number == array.Length - 1)
        {
            if (array[number] < array[number - 1 ])
            {
                bigger = false;
            }
        }
        
        if (number != 0 && number != array.Length - 1 )
        {
            if (array[number] < array[number + 1] || array[number] < array[number - 1])
            {
                bigger = false;
            }
        }
        return bigger;
    }
}