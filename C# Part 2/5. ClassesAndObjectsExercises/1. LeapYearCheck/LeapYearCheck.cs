using System;

class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year) == true)
        {
            Console.WriteLine("The year is leap.");
        }
        else
        {
            Console.WriteLine("The year is NOT leap.");
        }
    }
}
