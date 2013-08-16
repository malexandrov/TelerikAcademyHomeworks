using System;
using System.Numerics;

class FactorialFunction
{
    static void Main()
    {
        int n, k;
        string consoleInput;
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger result;
        BigInteger kMinusN = 1;

        do
        {
            Console.Write("Please enter K > 1: ");
        }
        while (!int.TryParse(consoleInput = Console.ReadLine(), out k) || k <= 1);

        do
        {
            Console.Write("Please enter N > 1 & N < K: ");
        }
        while (!int.TryParse(consoleInput = Console.ReadLine(), out n) || n <= 1 || n >= k);

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            kFact *= i;
        }
        for (int i = 1; i <= k - n; i++)
        {
            kMinusN *= i;
        }
        result = nFact * kFact / kMinusN;
        Console.WriteLine("N! * K! /(K-N)!  = {0}", result);
    }
}
