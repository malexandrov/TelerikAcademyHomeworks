using System;

// Not Working correctly

class CalculateNFacturielMethod
{
    static void Main()
    {
        int[] factorial = { 1 };
        for (int i = 1; i <= 100; i++)
        {
            PrintNumber(factorial = Multiply(factorial, i));
        }
    }

    static void PrintNumber(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--) Console.Write(arr[i]); 

        Console.WriteLine();
    }

    static int[] Multiply(int[] x, int y)
    {
        int[] result = { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        for (int i = 0; i < y; i++) result = AddArraysOfDigits(result, x);

        return result;
    }

    static int[] AddArraysOfDigits(int[] firstArray, int[] secondArray)
    {
        int[] result = new int[Math.Max(firstArray.Length, secondArray.Length) + 1];
        
        result[0] = (firstArray[0] + secondArray[0]) % 10;
        for (int i = 1; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            result[i] = (firstArray[i] + secondArray[i]) % 10 + (firstArray[i - 1] + secondArray[i - 1]) / 10;

            if (i == Math.Min(firstArray.Length, secondArray.Length) - 1)
            {
                if (firstArray.Length == secondArray.Length)
                {
                    result[i + 1] = (firstArray[i - 1] + secondArray[i - 1]) / 10;
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
        if (result[result.Length - 1] == 0)
        {
            Array.Resize(ref result, result.Length - 1);
        }

        return result;
    }
}