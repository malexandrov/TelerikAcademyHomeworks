using System;


class CalculateSumFromString
{
    static void Main()
    {
        string numberString = "43 68 9 23 318";
        string[] arrayOfNumbers = numberString.Split(' ');
        int sum = 0;

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            sum += int.Parse(arrayOfNumbers[i]);
        }
        Console.WriteLine(sum);
    }
}
