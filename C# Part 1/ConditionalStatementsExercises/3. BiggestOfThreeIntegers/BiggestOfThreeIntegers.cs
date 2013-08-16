using System;

class BiggestOfThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter three integer numbers:");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggestNumber = firstNumber;

        if (secondNumber > firstNumber)
        {
            if (secondNumber > thirdNumber)
            {
                biggestNumber = secondNumber;
            }
            else
            {
                biggestNumber = thirdNumber;
            }
         }
        Console.WriteLine("The biggest number is {0}.", biggestNumber);
    }
}
