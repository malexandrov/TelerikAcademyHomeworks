using System;

class PrintNumbersNotDivisible
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % (3*7) != 0)                     //NOD 21
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
