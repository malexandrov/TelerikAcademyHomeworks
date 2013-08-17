using System;

class EnterNumberInGivenRange
{
    static void Main()
    {
        int min = 1;
        int[] array = new int[10];

        for (int i = 0; i < 10; i++)
        {
            array[i] = ReadNumber(min, 100);
            min = array[i];
        }
    }

    static int ReadNumber(int start, int end)
    {
        int number = int.MinValue;
        try
        {
           number = int.Parse(Console.ReadLine());

           if (number >= end || number <= start)
           {
               throw new FormatException();
           }
        }

        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
        return number;
    }
}