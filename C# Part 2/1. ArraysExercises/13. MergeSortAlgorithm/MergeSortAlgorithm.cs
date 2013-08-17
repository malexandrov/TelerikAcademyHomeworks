using System;


class MergeSort
{
    static int[] LeftAndRight(int[] array)
    {
        if (array.Length == 1)
            return array;

        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }

        for (int i = 0; i < array.Length - middle; i++)
        {
            right[i] = array[i + middle];
        }
        left = LeftAndRight(left);
        right = LeftAndRight(right);
        return Merge(left, right);
    }

    static int[] Merge(int[] left, int[] right)
    {
        int[] sorted = new int[left.Length + right.Length];

        int leftptr = 0;
        int rightptr = 0;

        for (int k = 0; k < sorted.Length; k++)
        {
            if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
            {
                sorted[k] = left[leftptr];
                leftptr++;
            }
            else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
            {
                sorted[k] = right[rightptr];
                rightptr++;
            }
        }
        return sorted;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
   
        int[] array = { 1, 5, 7, 0, -2, 15, 34,-12,-17};
        int n = array.Length;

        int[] sortedArray = LeftAndRight(array);

        PrintArray(sortedArray);
    }
}
