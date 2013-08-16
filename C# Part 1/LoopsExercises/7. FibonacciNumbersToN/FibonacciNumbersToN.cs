using System;

class FibonacciNumbersToN
{
    static void Main()
    {
        long n = 0;
        long n_1 = 0;
        long n_2 = 1;
        long sum = 0;
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i < input ; i++)
        {
            n = n_1 + n_2;
            n_2 = n_1;
            n_1 = n;
            sum += n;
        }
        Console.WriteLine("The sum of the first {0} members is: {1}", input, sum);
    }
}
