using System;

class PrintDayOfTheWeek
{
    static void Main()
    {
        DateTime today = DateTime.Today;
        Console.WriteLine(today.DayOfWeek);
    }
}