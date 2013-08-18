using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DifferentShapesClass
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 3.25);
            Triangle triangle = new Triangle(6, 4.2);
            Circle circle = new Circle(15);

            List<Shape> arrayOfDifferentShapes = new List<Shape>();
            arrayOfDifferentShapes.Add(rectangle);
            arrayOfDifferentShapes.Add(triangle);
            arrayOfDifferentShapes.Add(circle);

            foreach (Shape shape in arrayOfDifferentShapes)
            {
                Console.WriteLine(shape.CalculateSurface()); 
            }
        }
    }
}
