using System;

class QuickSort
{
    static void Main(string[] args)
    {
        string[] arrayOfStrings = { "test", "quick", "sort", "string", "array", "algorithm" };

        Print(arrayOfStrings);
        Quicksort(arrayOfStrings, 0, arrayOfStrings.Length - 1);
        Print(arrayOfStrings);
    }

    public static void Print(string[] sortedArray)
    {
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.Write(sortedArray[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public static void Quicksort(string[] arrayOfStrings, int leftIndex, int rightIndex)
    {
        int pointerLeft = leftIndex;
        int pointerRight = rightIndex;
        string pivot = arrayOfStrings[(leftIndex + rightIndex) / 2];

        while (pointerLeft <= pointerRight)
        {
            while (arrayOfStrings[pointerLeft].CompareTo(pivot) < 0)
            {
                pointerLeft++;
            }

            while (arrayOfStrings[pointerRight].CompareTo(pivot) > 0)
            {
                pointerRight--;
            }

            if (pointerLeft <= pointerRight)
            {
                string temp = arrayOfStrings[pointerLeft];
                arrayOfStrings[pointerLeft] = arrayOfStrings[pointerRight];
                arrayOfStrings[pointerRight] = temp;
                pointerLeft++;
                pointerRight--;
            }
        }

        if (leftIndex < pointerRight)
        {
            Quicksort(arrayOfStrings, leftIndex, pointerRight);
        }

        if (pointerLeft < rightIndex)
        {
            Quicksort(arrayOfStrings, pointerLeft, rightIndex);
        }
    }
}