using System;

class GreatestOfFiveVariables
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers:");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());
        double biggestNumber = firstNumber;
       
        if (biggestNumber < secondNumber)
        {
            biggestNumber = secondNumber;
        }
        if (biggestNumber < thirdNumber)
        {
            biggestNumber = thirdNumber;
        }
        if (biggestNumber < fourthNumber)
        {
            biggestNumber = fourthNumber;
        }
        if (biggestNumber < fifthNumber)
        {
            biggestNumber = fifthNumber;
        }
        Console.WriteLine("The biggest number is: {0}", biggestNumber);
    }
}