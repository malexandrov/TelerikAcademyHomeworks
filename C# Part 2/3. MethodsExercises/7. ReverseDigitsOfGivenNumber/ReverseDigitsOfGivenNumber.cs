using System;


class ReverseDigitsOfGivenNumber
{
    static void Main()
    {
        int numberToReverse = int.Parse(Console.ReadLine());
        ReverseDigits(numberToReverse);
    }

    static void ReverseDigits(int numberToReverse)
    {
        do
        { 
            Console.Write(numberToReverse % 10);
            numberToReverse = numberToReverse / 10;
        }
        while (numberToReverse != 0);
        Console.WriteLine();
    }
}