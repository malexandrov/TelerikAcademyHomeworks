
using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] array = { 2, 1, 2, 5, 4, 2, 13, 14, 15, 16, 6, 8, 10};
        int sequence = 1;
        int maxSequence = 0;
        int element = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                sequence++;
            }
            else
            {
                if (maxSequence < sequence) 
                {
                    maxSequence = sequence;
                    element = i;
                }
                sequence = 1;
            }
        }

        if (sequence > maxSequence)
        {
            maxSequence = sequence;
            element = array.Length - 1;
        }


        Console.Write("{ ");
        for (int i = element - maxSequence + 1; i < element + 1; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine("}");
    }
}