using System;

class CalculateGreatestCommonDivisor
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int gcd = 0;
        int tmpNumber;

        if (firstNumber > 0 && secondNumber > 0)
        {
            while (secondNumber > 0)
            {
                tmpNumber = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = tmpNumber;
            }
            gcd = firstNumber;
            Console.WriteLine(gcd);
        }
    }
}