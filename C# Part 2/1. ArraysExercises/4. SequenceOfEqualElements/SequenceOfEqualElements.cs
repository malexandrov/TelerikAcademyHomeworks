using System;

class SequenceOfEqualElements
{
    static void Main()
    {
        int[] array = { 1, 1, 3, 2, 2, 1, 1, 1, 3, 3};
        int currentSequence = 1;
        int maximalSequence = 0;
        int element = 0;

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                currentSequence++;
            }
            else
            {
                if (maximalSequence < currentSequence)
                {
                    maximalSequence = currentSequence;
                    element = array[i];
                    currentSequence = 1;
                }
            }
        }

        Console.Write("{ ");
        for (int i = 0; i < maximalSequence; i++)
        {
            Console.Write("{0} ", element);
        }
        Console.Write("}");
        Console.WriteLine();
    }
}
