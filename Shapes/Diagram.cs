using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public enum eShapes
    {
        Ellipse,
        Circle,
        Rhomboid,
        Triangle,
        Rectangle,
        Square
    }
    internal class Diagram
    {
        private List<Shape2D> shapes;

        public Diagram(int numberOfShapes)
        {
            shapes = new List<Shape2D>();
            PopulateShapesList(numberOfShapes);
        }

        private void PopulateShapesList(int numberOfShapes)
        {
            Random random = new Random();

            for (int i = 1; i <= numberOfShapes; i++)
            {
                eShapes shape = (eShapes)random.Next(0, Enum.GetNames(typeof(eShapes)).Length);

                switch(shape)
                {
                    case eShapes.Ellipse:
                        Ellipse ellipse = new Ellipse(random.Next(1, 10), random.Next(1, 10));
                        shapes.Add(ellipse);
                        break;
                    case eShapes.Circle:
                        Circle circle = new Circle(random.Next(1, 10));
                        shapes.Add(circle);
                        break;
                    case eShapes.Rhomboid:
                        Rhomboid rhomboid = new Rhomboid(random.Next(1, 10), random.Next(1, 10));
                        shapes.Add(rhomboid);
                        break;
                    case eShapes.Triangle:
                        int b = random.Next(1, 10);
                        Triangle triangle = new Triangle(b, random.Next(1, 10), random.Next(1, b));
                        shapes.Add(triangle);
                        break;
                    case eShapes.Rectangle:
                        Rectangle rectangle = new Rectangle(random.Next(1, 10), random.Next(1, 10));
                        shapes.Add(rectangle);
                        break;
                    case eShapes.Square:
                        Square square = new Square(random.Next(1, 10));
                        shapes.Add(square);
                        break;
                }
            }
        }

        public int GetNumberOf(Type shapeType)
        {
            int count = 0;

            foreach(Shape2D shape in shapes)
                if(shape.GetType() == shapeType)
                    count++;

            return count;
        }
    }
}
