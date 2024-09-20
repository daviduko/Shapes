using System;

namespace Shapes
{
    internal class Ellipse : Shape2D
    {
        private double minorAxis, majorAxis;

        public Ellipse(double minorAxis, double majorAxis)
        {
            this.minorAxis = minorAxis;
            this.majorAxis = majorAxis;
        }

        public override double Area()
        {
            return Math.PI * minorAxis * majorAxis;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Math.Sqrt(((Math.Pow(minorAxis, 2)) + (Math.Pow(majorAxis, 2))) / 2);
        }
    }
}
