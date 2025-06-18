using Interview.Structural.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Bridge.Abstractions
{
    public class Rectangle : Shape
    {
        public Rectangle(IColor color) : base(color)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"this is a rectangle with the color {_color.fill()}");
        }
    }
}
