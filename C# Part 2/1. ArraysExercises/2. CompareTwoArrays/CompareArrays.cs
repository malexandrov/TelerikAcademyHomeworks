using System;


class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter arrays length:");

        int lengthOfArrays = int.Parse(Console.ReadLine());
        int[] array1 = new int[lengthOfArrays];
        int[] array2 = new int[lengthOfArrays];
        bool isEqual = true;

        Console.WriteLine("Enter elements for the FIRST array:");
        for (int i = 0; i < lengthOfArrays; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter elements for the SECOND array:");
        for (int i = 0; i < lengthOfArrays; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < lengthOfArrays; i++)
        {
            if (array1[i] != array2[i])
            {
                isEqual = false;
                break;
            }
        }
        Console.WriteLine("Equal = " + isEqual);
    }
}
