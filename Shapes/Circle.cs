
namespace Shapes
{
    internal class Circle : Ellipse
    {
        private double radius;
        public double Radius { get { return radius; } }

        public Circle(double radius) : base(radius, radius)
        {
            this.radius = radius;
        }
    }
}
