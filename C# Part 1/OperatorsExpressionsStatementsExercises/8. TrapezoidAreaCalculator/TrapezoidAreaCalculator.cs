using System;

class TrapezoidAreaCalculator
{
    static void Main()
    {
        Console.Write("Enter trapezoid side a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter trapezoid side b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter trapezoid height: ");
        int h = Convert.ToInt32(Console.ReadLine());
        int area = ((a + b) / 2) * h;
        Console.WriteLine("Trapezoid area is: {0}", area);
    }
}

