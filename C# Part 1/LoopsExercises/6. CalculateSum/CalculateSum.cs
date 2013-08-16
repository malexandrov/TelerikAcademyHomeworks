using System;

class CalculateSum
{
    static void Main()
    {
        int n;
        double nFact = 1;
        int x;
        double xSqrt;
        double sum = 1;
        string consoleInput;

        do
        {
            Console.Write("Please enter N > 1: ");
        }
        while (!int.TryParse(consoleInput = Console.ReadLine(), out n) || n <= 1);

        do
        {
            Console.Write("Please enter X: ");
        }
        while (!int.TryParse(consoleInput = Console.ReadLine(), out x));

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
            xSqrt = Math.Pow(x, i);
            sum += nFact / xSqrt;
        }
        Console.WriteLine(sum);
    }
}
