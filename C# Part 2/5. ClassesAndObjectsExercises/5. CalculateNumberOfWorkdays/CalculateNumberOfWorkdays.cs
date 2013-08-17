using System;

class CalculateNumberOfWorkdays
{
    static void Main()
    {
        Console.WriteLine("Enter end date year:");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end date month:");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end date day:");
        int day = int.Parse(Console.ReadLine());

        DateTime start = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);

        int length = 0;
        length = Math.Abs((endDay - start).Days);

        DateTime[] holidaysList =
            {
                new DateTime(2013, 1, 1),
                new DateTime(2013, 5, 25),
                new DateTime(2013, 9, 10),
                new DateTime(2013, 12, 25),
                new DateTime(2013, 12, 24)
            };

        int counter = 0;
        bool holiday = false;
 
        for (int i = 0; i < length; i++)
        {
            start = start.AddDays(1);
            if (start.DayOfWeek != DayOfWeek.Sunday && start.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidaysList.Length; j++)
                {
                    if (start == holidaysList[j])
                    {
                        holiday = true;
                        break;
                    }
                }
 
                if (!holiday)
                {
                    counter++;
                    holiday = false;
                }
            }
        }
        Console.WriteLine("Workdays: " + counter);
    }
}