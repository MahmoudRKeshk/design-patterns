using Interview.Structural.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Bridge.Abstractions
{
    public class Triangle : Shape
    {
        public Triangle(IColor color) : base(color)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"this is a triangle with the color {_color.fill()}");
        }
    }
}
