using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        public double Radius { get;  protected set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area
        {
            get{ return Math.PI * Math.Pow(Radius, 2); }            
        }
    }
}
