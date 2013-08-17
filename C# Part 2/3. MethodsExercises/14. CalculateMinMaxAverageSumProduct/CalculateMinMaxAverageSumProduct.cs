using System;

class CalculateMinMaxAverageSumProduct
{

    static void Main()
    {
        int[] arrayOfInt = { 1, -13, 5, -7, 11, -2, 4, 9, 31 };
        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            Console.Write(arrayOfInt[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Min: " + MinValue(arrayOfInt));
        Console.WriteLine("Max: " + MaxValue(arrayOfInt));
        Console.WriteLine("Average: " + Average(arrayOfInt));
        Console.WriteLine("Sum: " + Sum(arrayOfInt));
        Console.WriteLine("Product: " + Product(arrayOfInt));
    }

    static int MinValue(int[] arrayOfInt)
    {
        int min = int.MaxValue;
        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            if (arrayOfInt[i] < min)
            {
                min = arrayOfInt[i];
            }
        }
        return min;
    }

    static int MaxValue(int[] arrayOfInt)
    {
        int max = int.MinValue;
        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            if (arrayOfInt[i] > max)
            {
                max = arrayOfInt[i];
            }
        }
        return max;
    }

    static decimal Average(int[] arrayOfInt)
    {
        decimal sum = 0;
        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            sum += arrayOfInt[i];
        }
        return (sum / arrayOfInt.Length);
    }

    static long Sum(int[] arrayOfInt)
    {
        long sum = 0;
        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            sum += arrayOfInt[i];
        }
        return sum;
    }

    static long Product(int[] arrayOfInt)
    {
        long product = 1;
        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            product *= arrayOfInt[i];
        }
        return product;
    }
}

    
