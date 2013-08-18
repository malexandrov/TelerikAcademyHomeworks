using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DifferentShapesClass
{
    class Triangle : Shape
    {

        public Triangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double surface;
            surface = height * width / 2;
            return surface;
        }
     }
}
