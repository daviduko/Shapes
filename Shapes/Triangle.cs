using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Polygon
    {
        private double b, height, alpha;

        public Triangle(double b, double height, double alpha)
        {
            numberOfSides = 3;
            this.b = b;
            this.height = height;
            this.alpha = alpha;
        }

        public override double Area()
        {
            return (b * height) / 2;
        }

        public override double Perimeter()
        {
            return base.Perimeter();
        }
    }
}
