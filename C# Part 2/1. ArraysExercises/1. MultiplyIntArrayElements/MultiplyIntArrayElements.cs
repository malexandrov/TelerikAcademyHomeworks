using System;

class MultiplyIntArrayElements
{
    static void Main()
    {
        int[] arrayOfInt = new int[20];
        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            arrayOfInt[i] = 5 * i;
            Console.WriteLine(arrayOfInt[i]);
        }
    }
}
