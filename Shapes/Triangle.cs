
using System;

namespace Shapes
{
    internal class Triangle : Polygon
    {
        private double b, height, alpha;
        private double side1, side2, side3;

        public Triangle(double b, double height, double alpha)
        {
            numberOfSides = 3;
            this.b = b;
            this.height = height;
            this.alpha = alpha;
            CalculateSides();
        }

        public override double Area()
        {
            return (b * height) / 2;
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }

        private void CalculateSides()
        {
            side1 = b;
            side2 = Math.Sqrt(Math.Pow(alpha, 2) + Math.Pow(height, 2));
            side3 = Math.Sqrt(Math.Pow(b - alpha, 2) + Math.Pow(height, 2));
        }
    }
}
