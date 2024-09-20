using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Polygon
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            numberOfSides = 2;
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return side1 * 2 + side2 * 2;
        }
    }
}
