using System;

class QuadraticEquationCalc
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double x1, x2;
        double discriminant = (b * b) - 4 * a * c;


        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots.");
        }
        else if (discriminant == 0)
        {
            x1 = -(b / (2 * a));
            Console.WriteLine("There is only one real root x1=x2: " + x1);
        }
        else
        {
            double sqrt = Math.Sqrt(discriminant);
            x1 = (-b + sqrt) / (2 * a);
            x2 = (-b - sqrt) / (2 * a);
            Console.WriteLine("There are two real roots x1 = {0} and x2 = {1}", x1, x2);
        }
    }
}
