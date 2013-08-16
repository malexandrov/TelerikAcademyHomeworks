using System;

class FactorialNDividedByK
{
    static void Main()
    {
        int n, k;
        string consoleInput;
        decimal nFact = 1;
        decimal kFact = 1;
        decimal result;

        do
        {
            Console.Write("Please enter N > 1: ");
        }
        while (!int.TryParse(consoleInput = Console.ReadLine(), out n) || n <= 1);

        do
        {
            Console.Write("Please enter K > 1 & K < N: ");
        }
        while (!int.TryParse(consoleInput = Console.ReadLine(), out k) || k <= 1 || k > n);

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            kFact *= i;
        }
        result = nFact / kFact;
        Console.WriteLine("N! / K! = {0}", result);
    }
}
