using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Shape2D
    {
        public virtual double Area() { return double.MinValue; }
        public virtual double Perimeter() { return double.MinValue; }
    }
}
