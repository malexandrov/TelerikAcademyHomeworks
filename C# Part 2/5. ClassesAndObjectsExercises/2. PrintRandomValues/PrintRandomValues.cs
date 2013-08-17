using System;

class PrintRandomValues
{
    static void Main()
    {
        Random randomNumber = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomNumber.Next(101)+100);
        }
    }
}