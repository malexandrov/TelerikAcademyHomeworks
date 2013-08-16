using System;

class PrintAgeAfterYears
{
    static void Main()
    {
        Console.WriteLine("Please enter your age:");
        string ageNow = Console.ReadLine();
        int ageThen = Convert.ToInt32(ageNow);
        Console.WriteLine("After 10 years your age will be: {0}", ageThen + 10);
    }
}

