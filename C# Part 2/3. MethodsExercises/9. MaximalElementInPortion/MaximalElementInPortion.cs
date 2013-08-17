using System;

class MaximalElementInPortion
{
    static void Main()
    {
        int[] array = { 2, -3, 5, -7, 9, -4, 1 };
        int startElement = 3;

        Console.Write("Best element index: ");
        Console.WriteLine(MaxElementInPortion(array, startElement));
        Console.Write("Sorted array: ");
        SortArray(array, -1);                                               // 1 for Ascending order, -1 for Descending

        Console.WriteLine();
    }

    static int MaxElementInPortion(int[] array, int start)
    {
        int maxElementIndex = start;

        for (int j = start + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxElementIndex])
            {
                maxElementIndex = j;
            }
        }
        return maxElementIndex;

    }

    static void SortArray(int[] array, int direction)
    {
        int swap = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                int temp = MaxElementInPortion(array, i);
                swap = array[i];
                array[i] = array[temp];
                array[temp] = swap;
            }
        if (direction == -1)
        {
            Array.Reverse(array);
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}