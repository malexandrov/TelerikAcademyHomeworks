using System;

class CombinationsWithDuplicates
{
    static void Main()
    {
        int n = 3;
        int k = 2;
        int[] array = new int[k];

        GenerateCombinations(array, 0, 1, n);
    }

    static void GenerateCombinations(int[] array, int index, int startNum, int n)
    {
        if (index >= array.Length)
        {
            Console.WriteLine("(" + String.Join(", ", array) + ")");
            return;
        }
        else
        {
            for (int i = startNum; i <= n; i++)
            {
                array[index] = i;
                GenerateCombinations(array, index + 1, i , n);
            }
        }
    }
}
