using System;

namespace Shapes
{
    internal class Rhomboid : Polygon
    {
        private double diagonal1, diagonal2;
        public double Diagonal1 { get { return diagonal1; } }
        public double Diagonal2 { get { return diagonal2; } }

        public Rhomboid(double diagonal1, double diagonal2)
        {
            numberOfSides = 4;
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }

        public override double Area()
        {
            return diagonal1 * diagonal2;
        }

        public override double Perimeter()
        {
            return 4 * Math.Sqrt(Math.Pow((diagonal1 / 2), 2) + Math.Pow((diagonal2 / 2), 2));
        }
    }
}
