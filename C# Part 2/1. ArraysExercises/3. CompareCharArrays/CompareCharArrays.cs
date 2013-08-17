using System;

class CompareCharArrays
{
    static void Main()
    {
        char[] array1 = { 'a', 'b', 'c', 'd', 'E' };
        char[] array2 = { 'a', 'b', 'c', 'd', 'e' };
        bool isEqual = true;

        if (array1.Length != array2.Length)
        {
            isEqual = false;
            Console.WriteLine("Equal = " + isEqual);
        }
        else
        {
            for (int i = 0; i < array1.Length; i++)
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
}