using System;

class IntValueExchange
{
    static void Main()
    {
        Console.WriteLine("Please number N1:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please number N2:");
        int secondNumber = int.Parse(Console.ReadLine());
        int tempNumber;

        if (firstNumber > secondNumber)
        {
            tempNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempNumber;
        }
        Console.WriteLine("The value of number N1 now is: {0}. The value of number N2 now is: {1}", firstNumber, secondNumber);
    }
}
