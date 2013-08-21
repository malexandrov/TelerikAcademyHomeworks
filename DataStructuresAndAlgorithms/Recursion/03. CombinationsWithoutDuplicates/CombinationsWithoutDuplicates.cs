using System;

class CombinationsWithoutDuplicates
{
    static void Main()
    {
        int n = 4;
        int k = 4;
        int startNum = 1;
        int[] array = new int[k];

        GenerateCombinations(array, 0, startNum, n);
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
                GenerateCombinations(array, index + 1, i + 1, n);
            }
        }
    }
}
