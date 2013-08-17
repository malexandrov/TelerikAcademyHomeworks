using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine( DigitToWord(number) );
    }

    static string DigitToWord(int number)
    {
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string word = words[number % 10]; 
        return word;
    }
}