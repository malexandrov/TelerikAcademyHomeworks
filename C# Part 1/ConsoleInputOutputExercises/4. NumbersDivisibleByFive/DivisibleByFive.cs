using System;

class DivisibleByFive
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                result++;
            }
        }
        Console.WriteLine("The number of dividers between {0} and {1} is {2}", a, b, result);
    }
}
