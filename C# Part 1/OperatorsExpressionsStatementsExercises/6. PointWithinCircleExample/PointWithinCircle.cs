using System;

class PointWithinCircle
{
    static void Main()
    {
        Console.Write("Enter point x coordinate: "); 
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter point y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());
        bool result = x * x + y * y <= 5 * 5;
        Console.WriteLine(result ? "The point is inside circle with radius 5" : "The point is outside circle with radius 5");
    }
}

