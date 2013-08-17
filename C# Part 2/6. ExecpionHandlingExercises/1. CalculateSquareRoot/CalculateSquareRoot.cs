using System;

class Program
{
    static void Main()
    {
        
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new FormatException();
            }
            Console.WriteLine(Math.Sqrt(number));

        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number!");
        }

        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number");
        }

        finally 
        {
            Console.WriteLine("Goodbye!");
        }
    }
}