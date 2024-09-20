﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rhomboid : Polygon
    {
        private double diagonal1;
        private double diagonal2;

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
