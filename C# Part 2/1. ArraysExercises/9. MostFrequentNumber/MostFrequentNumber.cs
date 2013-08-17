using System;

class MostFrequentNumber
{
    static void Main()
    {
        int result = 1;
        int tempResult = 1;
        int resultElement = int.MinValue;
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != int.MinValue)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        tempResult += 1;
                        array[j] = int.MinValue;
                    }
                }
            }
            if (tempResult > result)
            {
                resultElement = array[i];
                result = tempResult;
                tempResult = 1;
            }
        }
        Console.WriteLine("{0} ({1} Times)", resultElement, result);
    }
}