using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = [
                new Square(color: "Yellow", side: 4),
                new Rectangle(color: "Blue", length: 3, width: 4),
                new Circle(color: "Green", radius: 3),
            ];

            foreach (Shape shape in shapes)
            {
                string area = shape.GetArea().ToString("F2");
                Console.WriteLine($"Shape with color {shape.GetColor()} has an area of {area}ft.");
            }
        }
    }
}
