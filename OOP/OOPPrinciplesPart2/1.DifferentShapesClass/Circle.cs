using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DifferentShapesClass
{
    class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, height: radius)
        {
        }

        public override double CalculateSurface()
        {
            return this.height * this.width * Math.PI;
        }
    }
}
