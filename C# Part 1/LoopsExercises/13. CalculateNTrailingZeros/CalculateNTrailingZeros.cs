using System;

class CalculateNTrailingZeros
{
    static void Main()
    {
        long n;
        n = int.Parse(Console.ReadLine()); 
        int pow = 1;
        long sumOfTrailingZeros = 0; 

        do
        {
            sumOfTrailingZeros = sumOfTrailingZeros + (n / (long)Math.Pow(5, pow));
            pow++;
        }
        while (Math.Pow(5, pow) <= n);

        Console.WriteLine(sumOfTrailingZeros);

    }
}
