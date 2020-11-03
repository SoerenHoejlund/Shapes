using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        public double Width { get; protected set; }

        public Square(double width)
        {
            Width = width;
        }

        public override double Area
        {
            get { return Math.Pow(Width, 2); }
        }
    }
}
