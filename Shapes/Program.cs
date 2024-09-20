using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    enum eOptions
    {
        Exit,
        Ellipse,
        Circle,
        Rhomboid,
        Triangle,
        Rectangle,
        Square,
        Diagram
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            eOptions option;

            do
            {
                Console.WriteLine(@"
0. Exit
1. Ellipse
2. Circle
3. Rhomboid
4. Triangle
5. Rectangle
6. Square
7. Diagram");

                option = (eOptions)int.Parse(Console.ReadLine());

                switch(option)
                {
                    case eOptions.Exit:
                        return;
                    case eOptions.Ellipse:
                        Ellipse ellipse = new Ellipse(AskForValue("minor axis"), AskForValue("major axis"));
                        Console.WriteLine($"Area: {ellipse.Area()}\nPerimeter: {ellipse.Perimeter()}");
                        break;
                    case eOptions.Circle:
                        Circle circle = new Circle(AskForValue("radius"));
                        Console.WriteLine($"Area: {circle.Area()}\nPerimeter: {circle.Perimeter()}");
                        break;
                    case eOptions.Rhomboid:
                        Rhomboid rhomboid = new Rhomboid(AskForValue("first diagonal"), AskForValue("second diagonal"));
                        Console.WriteLine($"Area: {rhomboid.Area()}\nPerimeter: {rhomboid.Perimeter()}");
                        break;
                    case eOptions.Triangle:
                        Triangle triangle = new Triangle(AskForValue("base"), AskForValue("height"), AskForValue("alpha"));
                        Console.WriteLine($"Area: {triangle.Area()}\nPerimeter: {triangle.Perimeter()}");
                        break;
                    case eOptions.Rectangle:
                        Rectangle rectangle = new Rectangle(AskForValue("first side"), AskForValue("second side"));
                        Console.WriteLine($"Area: {rectangle.Area()}\nPerimeter: {rectangle.Perimeter()}");
                        break;
                    case eOptions.Square:
                        Square square = new Square(AskForValue("side"));
                        Console.WriteLine($"Area: {square.Area()}\nPerimeter: {square.Perimeter()}");
                        break;
                    case eOptions.Diagram:
                        CreateDiagram();
                        break;
                }

            } while (AskToContinue("Do you want to create another shape?"));
        }

        static void CreateDiagram()
        {
            int numberOfShapes = (int)AskForValue("number of shapes");
            Diagram diagram = new Diagram(numberOfShapes);

            Console.WriteLine("A diagram has been created");
            Console.WriteLine($@"
The diagram has:
    {diagram.GetNumberOf(typeof(Ellipse))} number of ellipses
    {diagram.GetNumberOf(typeof(Circle))} number of circles
    {diagram.GetNumberOf(typeof(Rhomboid))} number of rhomboids
    {diagram.GetNumberOf(typeof(Triangle))} number of triangles
    {diagram.GetNumberOf(typeof(Rectangle))} number of rectangles
    {diagram.GetNumberOf(typeof(Square))} number of squares

Total area: {diagram.GetTotalArea()}u^2
Total perimeter: {diagram.GetPerimeter()}u");
        }

        static double AskForValue(string valueName)
        {
            double inputValue;

            do
            {
                Console.WriteLine($"Please, introduce {valueName} value:");
            } while (!double.TryParse(Console.ReadLine(), out inputValue));

            return inputValue;
        }

        static bool AskToContinue(string question)
        {
            string answer;
            bool keep = true;
            do
            {
                Console.WriteLine($"{question} (y/n)");
                answer = Console.ReadLine();
            } while (answer != "y" && answer != "n");

            if (answer == "n")
                keep = false;

            return keep;
        }
    }
}
