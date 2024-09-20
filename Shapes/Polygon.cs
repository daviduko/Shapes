using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Polygon : Shape2D
    {
        protected int numberOfSides;
        public int NumberOfSides {  get { return numberOfSides; } }
    }
}
