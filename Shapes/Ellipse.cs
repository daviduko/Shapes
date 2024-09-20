using System;

namespace Shapes
{
    internal class Ellipse : Shape2D
    {
        private double axis1, axis2;

        public Ellipse(double axis1, double axis2)
        {
            this.axis1 = axis1;
            this.axis2 = axis2;
        }

        public override double Area()
        {
            return Math.PI * axis1 * axis2;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Math.Sqrt(((Math.Pow(axis1, 2)) + (Math.Pow(axis2, 2))) / 2);
        }
    }
}
