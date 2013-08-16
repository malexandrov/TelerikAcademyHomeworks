using System;

class ThreeNumbersProductSign
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers:");
        float firstNumber = float.Parse(Console.ReadLine());
        float secondNumber = float.Parse(Console.ReadLine());
        float thirdNumber = float.Parse(Console.ReadLine());
        bool sign = true;

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product is 0");
        }
        else
        {
            if (firstNumber < 0)
            {
                sign = !sign;
            }
            if (secondNumber < 0)
            {
                sign = !sign;
            }
            if (thirdNumber < 0)
            {
                sign = !sign;
            }
            Console.WriteLine("The product of the numbers has a {0} sign.", (sign ? "Positive" : "Negative"));
        }

    }
}
