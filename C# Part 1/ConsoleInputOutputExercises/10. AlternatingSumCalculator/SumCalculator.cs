using System;

class SumCalculator
{
    static void Main()
    {
        double n = 1;
        double previousN = 0;
        const double precision = 0.001;
        double sign = 2;

        while (Math.Abs(n - previousN) > precision)
        {
            if (sign % 2 == 0)
            {
                previousN = n;
                n = previousN + (1/sign);
            }
            else 
            {
                previousN = n;
                n = previousN - (1/sign);
            }
            sign++;
            Console.WriteLine(n);
        }
    }
}
