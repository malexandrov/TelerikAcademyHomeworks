namespace SizeClass_Exercise1
{
    using System;

    class FigureSizeExample
    {
        public static Figure GetRotatedFigure(Figure figure, double angleOfRotation)
        {
            double angleCos = Math.Cos(angleOfRotation);
            double angleSin = Math.Sin(angleOfRotation);
            double newFigureWidth = Math.Abs(angleCos * figure.Width + angleSin * figure.Height);
            double newFigureHeight = Math.Abs(angleCos * figure.Height + angleSin * figure.Width);
            Figure resultingFigure = new Figure(newFigureWidth, newFigureHeight);

            return resultingFigure;
        }

        static void Main(string[] args)
        {
        }
    }
}

