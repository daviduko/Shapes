using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    enum eOption
    {
        Exit,
        Ellipse,
        Circle,
        Rhomboid,
        Triangle,
        Rectangle,
        Square
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            eOption option;

            do
            {
                Console.WriteLine(@"
0. Exit
1. Ellipse
2. Circle
3. Rhomboid
4. Triangle
5. Rectangle
6. Square");

                option = (eOption)int.Parse(Console.ReadLine());

                switch(option)
                {
                    case eOption.Exit:
                        return;
                    case eOption.Ellipse:
                        Ellipse ellipse = new Ellipse(AskForValue("minor axis"), AskForValue("major axis"));
                        Console.WriteLine($"Area: {ellipse.Area()}\nPerimeter: {ellipse.Perimeter()}");
                        break;
                    case eOption.Circle:
                        Circle circle = new Circle(AskForValue("radius"));
                        Console.WriteLine($"Area: {circle.Area()}\nPerimeter: {circle.Perimeter()}");
                        break;
                    case eOption.Rhomboid:
                        Rhomboid rhomboid = new Rhomboid(AskForValue("first diagonal"), AskForValue("second diagonal"));
                        Console.WriteLine($"Area: {rhomboid.Area()}\nPerimeter: {rhomboid.Perimeter()}");
                        break;
                    case eOption.Triangle:
                        Triangle triangle = new Triangle(AskForValue("base"), AskForValue("height"), AskForValue("alpha"));
                        Console.WriteLine($"Area: {triangle.Area()}\nPerimeter: {triangle.Perimeter()}");
                        break;
                    case eOption.Rectangle:
                        Rectangle rectangle = new Rectangle(AskForValue("first side"), AskForValue("second side"));
                        Console.WriteLine($"Area: {rectangle.Area()}\nPerimeter: {rectangle.Perimeter()}");
                        break;
                    case eOption.Square:
                        Square square = new Square(AskForValue("side"));
                        Console.WriteLine($"Area: {square.Area()}\nPerimeter: {square.Perimeter()}");
                        break;
                }

            } while (AskToContinue("Do you want to create another shape?"));
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
