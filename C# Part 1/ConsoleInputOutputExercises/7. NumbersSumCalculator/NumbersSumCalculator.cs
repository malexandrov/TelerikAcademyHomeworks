using System;

class NumbersSumCalculator
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter another number: ");
            result = result + int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum of the {0} numbers you entered is: {1}", n, result);
    }
}
