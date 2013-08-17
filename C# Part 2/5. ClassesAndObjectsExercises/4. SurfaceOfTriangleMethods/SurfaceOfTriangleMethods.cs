using System;

class SurfaceOfTriangleMethods
{
    static void Main()
    {
        CalcBySideAndAlt(3, 4);
        CalcByThreeSides(3, 4, 5);
        CalcByTwoSidesAngle(3, 4, 90);
    }

    private static void CalcBySideAndAlt(double a, double h)
    {
        Console.WriteLine("S = {0}", a * h / 2);
    }

    private static void CalcByThreeSides(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        Console.WriteLine("S = {0}", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
    }

    private static void CalcByTwoSidesAngle(double a, double b, double angle)
    {
        Console.WriteLine("S = {0}", a * b * Math.Sin(Math.PI * angle / 180) / 2);
    }
}