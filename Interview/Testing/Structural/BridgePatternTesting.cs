using Interview.Structural.Bridge.Abstractions;
using Interview.Structural.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Structural
{
    public static class BridgePatternTesting
    {
        public static void Run()
        {
            // Create instances of colors
            var red = new Red();
            var green = new Green();
            var yellow = new Yellow();


            // Create instances of shapes with different colors
            var redSquare = new Square(red);
            var greenTriangle = new Triangle(green);
            var yellowRectangle = new Rectangle(yellow);

            // Draw shapes
            redSquare.Draw();      
            greenTriangle.Draw();  
            yellowRectangle.Draw();
        }
    }
}
