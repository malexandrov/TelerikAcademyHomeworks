using System;

class MaxSumSequence
{
    static void Main()
    {
        decimal result = 0;
        decimal tempSum = 0;
        int tempStart = 0;
        int startIndex = 0;
        int endIndex = 0;

        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        for (int i = 0; i < array.Length; i++)
        {
            tempSum += array[i];
            if (tempSum > result)
            {
                result = tempSum;
                startIndex = tempStart;
                endIndex = i;
            }
            if (tempSum < 0)
            {
                tempSum = 0;
                tempStart = i + 1;
            }
        }

        Console.Write("{ ");
        for (int i = startIndex; i <= endIndex; ++i)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.Write("} = " + result);
        Console.WriteLine();
    }
}
