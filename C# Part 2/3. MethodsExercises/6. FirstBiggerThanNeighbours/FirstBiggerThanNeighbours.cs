using System;

class BiggerThanNeighbours
{
    static void Main()
    {
        int[] array = { 11, 11, 11, 11, 11, 11 };

        Console.WriteLine("First element bigger than its neighbours: " + CheckNeighbours(array));
    }

    static int CheckNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {

            if (i == 0)
            {
                if (array[i] > array[i + 1])
                {
                    return i;
                }
            }
            if (i == array.Length - 1)
            {
                if (array[i] > array[i - 1])
                {
                    return i;
                }
            }

            if (i != 0 && i != array.Length - 1)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    return i;
                }
            }
        }
        return -1;
    }
}