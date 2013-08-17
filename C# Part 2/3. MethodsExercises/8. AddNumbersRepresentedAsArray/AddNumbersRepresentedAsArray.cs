using System;

class AddNumbersRepresentedAsArray
{
    static void Main()
    {
        int[] firstArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] secondArray = { 5, 6, 7, 8, 9 };

        Console.WriteLine("Left to rigth:");
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write(firstArray[i]);
        }
        Console.WriteLine();

        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write(secondArray[i]);
        }
        Console.WriteLine();

        AddArraysOfDigits(firstArray, secondArray);
    }

    static void AddArraysOfDigits(int[] firstArray, int[] secondArray)
    {
        int[] result = new int[Math.Max(firstArray.Length, secondArray.Length)+1];
                      

        result[0] = (firstArray[0] + secondArray[0]) % 10;
        for (int i = 1; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            result[i] = (firstArray[i] + secondArray[i]) % 10 + (firstArray[i-1] + secondArray[i-1]) / 10;
           
            if (i == Math.Min(firstArray.Length, secondArray.Length) - 1)
            {
                if (firstArray.Length == secondArray.Length)
                {
                    result[i+1] = (firstArray[i - 1] + secondArray[i - 1]) / 10;
                    break;  
                }
                if (firstArray.Length > secondArray.Length)
                {
                    result[i + 1] = firstArray[i + 1] % 10 + (firstArray[i - 1] + secondArray[i - 1]) / 10;
                    break;  
                }
                if (secondArray.Length > firstArray.Length)
                {
                    result[i + 1] = secondArray[i + 1] % 10 + (firstArray[i - 1] + secondArray[i - 1]) / 10;
                    break;
                }
            }
        }

        // If one of the arrays is longer populate the resulting array only with the longer of them
        for (int i = Math.Min(firstArray.Length, secondArray.Length) + 1; i < Math.Max(firstArray.Length, secondArray.Length); i++)
        {
            if (firstArray.Length > secondArray.Length)
            {
                result[i] = firstArray[i];
            }
            if (secondArray.Length > firstArray.Length)
            {
                result[i] = secondArray[i];
            }
        }

        // Cut off that trailing zero
        if (result[result.Length-1] == 0)
        {
            Array.Resize(ref result, result.Length - 1);
        }

        // Print the result 
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();

        Array.Reverse(result);

        // Print reversed result
        Console.WriteLine();
        Console.WriteLine("The reversed result");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}