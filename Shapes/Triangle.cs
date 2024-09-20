using System;

namespace Shapes
{
    internal class Triangle : Polygon
    {
        private double b, height, alpha;
        private double side1, side2, side3;

        public double Base { get { return b; } }
        public double Height { get { return b; } }
        public double Alpha 
        { 
            get 
            { 
                return alpha; 
            } 
            private set
            {
                if(value > b)
                {
                    alpha = b;
                    Console.WriteLine("Alpha can't be bigger than the base of the triangle. Alpha value has been set same as base");
                }
                else
                    alpha = value;
            }
        }

        public Triangle(double b, double height, double alpha)
        {
            numberOfSides = 3;
            this.b = b;
            this.height = height;
            Alpha = alpha;
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
