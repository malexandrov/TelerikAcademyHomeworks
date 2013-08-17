using System;

class SequenceOfGivenSum
{
    static void Main()
    {
        int S = int.Parse(Console.ReadLine());
        int tempSum = int.MinValue;

        int[] array = { 4, 3, 1, 4, 2, 5, 8 };

        for (int i = 0; i < array.Length; i++)
        {
            tempSum = 0;
            for (int j = i; j < array.Length; j++)
            {
                tempSum += array[j];                        // Sum the array elements while their sum is smaller than S
                if (tempSum > S)
                {
                    break; 
                }
                if (tempSum == S)                           // If a sequence with sum S is found, print the sequence
                {                                           // with a start reference i from the first cycle and end reference j
                    Console.Write("{ ");
                    for (int printIndex = i; printIndex <= j; printIndex++)
                    {
                        Console.Write("{0} ", array[printIndex]);
                    }
                    Console.Write("} ");
                }
            }
        }
    }
}