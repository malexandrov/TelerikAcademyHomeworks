using System;

class SortThreeValues
{
    static void Main()
    {
        Console.WriteLine("Please enter three integer numbers:");
        float firstNumber = float.Parse(Console.ReadLine());
        float secondNumber = float.Parse(Console.ReadLine());
        float thirdNumber = float.Parse(Console.ReadLine());
        float tempNumber = firstNumber;

        if (firstNumber < secondNumber)
        {
            tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
        }
        if (firstNumber < thirdNumber)
        {
            tempNumber = firstNumber;
            firstNumber = thirdNumber;
            thirdNumber = tempNumber;
        }
        if (secondNumber < thirdNumber)
        {
            tempNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = tempNumber;
        }

        Console.WriteLine("The numbers in descending order:");
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        Console.WriteLine(thirdNumber);
    }
}
