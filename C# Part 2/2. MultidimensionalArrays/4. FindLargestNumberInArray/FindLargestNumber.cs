using System;

class FindLargestNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int k = int.Parse(Console.ReadLine());
        int index = int.MinValue;
                
        Array.Sort(array);
        index = Array.BinarySearch(array, k);

        if (index < 0)
        {
            Console.WriteLine("Largest number <= k is" + array[~index - 1]);
        }
        else
        {
            Console.WriteLine("Largest number <= k is " + array[index]);
        }
    }
}