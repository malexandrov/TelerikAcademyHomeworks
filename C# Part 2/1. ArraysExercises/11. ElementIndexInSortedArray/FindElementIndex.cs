using System;

class FindElementIndex
{
    static void Main()
    {
        int[] array = { 1, 3, 7, 11, 12, 14, 17, 21, 32, 100 };
        int key = int.Parse(Console.ReadLine());
        int minIndex = 0;
        int maxIndex = array.Length - 1;
        int middleIndex;
        
        Array.Sort(array);

        while (maxIndex >= minIndex)
        {
            middleIndex = (maxIndex + minIndex) / 2;

            if (array[middleIndex] < key)
            {
                minIndex = middleIndex + 1;
            }
            else if (array[middleIndex] > key)
            {
                maxIndex = middleIndex - 1;
            }
            else
            {
                Console.WriteLine("Index found at: " + middleIndex);
                break;
            }
        }
    }
}
