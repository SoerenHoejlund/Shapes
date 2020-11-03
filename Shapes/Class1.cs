using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Square square1 = new Square(4);
            Square square2 = new Square(5);

            Shape[] shapes = { circle, square1, square2 };

            foreach (var s in shapes)
            {
                Console.WriteLine("Arealet af {0} er {1}", "hej" , s.Area);  
            }
        }
    }
}
