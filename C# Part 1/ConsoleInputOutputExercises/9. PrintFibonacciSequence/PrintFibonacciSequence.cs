using System;

class PrintFibonacciSequence
{
    static void Main()
    {
        decimal n = 0;
        decimal n_1 = 0; 
        decimal n_2 = 1;

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(n);
            n = n_1 + n_2;
            n_2 = n_1;
            n_1 = n;
        }
    }
}
