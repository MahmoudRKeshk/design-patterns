using Interview.Structural.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Bridge.Abstractions
{
    public class Square : Shape
    {
        public Square(IColor color) : base (color)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"this is a square with the color {_color.fill()}");
        }
    }
}
