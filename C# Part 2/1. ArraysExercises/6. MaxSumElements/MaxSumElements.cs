using System;

class MaxSumElements
{
    static void Main()
    {
        Console.WriteLine("Enter number of array elements N:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter N elements for the array:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int maxSum = 0;
        int currentElement = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (k + i <= array.Length)
            {
                for (int j = i; j < k + i; j++)
                {
                    sum = sum + array[j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                sum = 0;
            }
        }

        Console.WriteLine(maxSum);
    }
}
