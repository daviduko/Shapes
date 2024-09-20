using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Polygon
    {
        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {
            numberOfSides = 3;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Area()
        {
            return base.Area();
        }
    }
}
