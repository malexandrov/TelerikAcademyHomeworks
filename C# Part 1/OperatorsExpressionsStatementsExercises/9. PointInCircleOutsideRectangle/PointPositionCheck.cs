using System;

class PointPositionCheck
{
    static void Main()
    {
        Console.Write("Enter point x coordinate: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Enter point y coordinate: ");
        float y = float.Parse(Console.ReadLine());
        bool inCircle = ((x-1) * (x-1) + (y-1) * (y-1) <= 9);
        bool inRectangle = ((x > 1) && (x < 7)) && ((y < -1) && (y > -3));
        Console.WriteLine(inCircle && !inRectangle);
    }
}
