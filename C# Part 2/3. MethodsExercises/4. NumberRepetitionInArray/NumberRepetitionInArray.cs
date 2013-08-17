using System;

class NumberRepetitionInArray
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 6, 2, 6, 8, 3, 5, 6, 0, 2, 2, 4, 5, 3, 3, 3, 1 };
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        CountNumberRepetitions(array, number);
    }

    static void CountNumberRepetitions(int[] array, int number)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                sum++;
            }
        }
        Console.WriteLine(sum);
    }
}
