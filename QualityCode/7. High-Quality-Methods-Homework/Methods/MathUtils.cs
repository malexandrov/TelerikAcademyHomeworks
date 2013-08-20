using System;

class MathUtils
{
    public static int FindMax(params int[] elements)
    {
        if (elements == null)
        {
            throw new ArgumentNullException("Array is null.");
        }
        if (elements.Length == 0)
        {
            throw new ArgumentException("No arguments specified.");
        }

        int maxElement = int.MinValue;
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] > maxElement)
            {
                maxElement = elements[i];
            }
        }

        return maxElement;
    }

    public static double CalcTriangleArea(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Triangle side lengths must be positive.");
        }

        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }

    public static double CalcPointsDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
        return distance;
    }

    public static bool IsLineHorizontal(double x1, double y1, double x2, double y2)
    {
        if (x1 == x2 && y1 == y2)
        {
            throw new ArgumentException("The points shouldn't coincide. A single point cannot define a line.");
        }

        return y1 == y2;
    }

    public static bool IsLineVertical(double x1, double y1, double x2, double y2)
    {
        if (x1 == x2 && y1 == y2)
        {
            throw new ArgumentException("The points shouldn't coincide. A single point cannot define a line.");
        }

        return x1 == x2;
    }
}