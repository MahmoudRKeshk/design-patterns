using Interview.Structural.Bridge.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Bridge.Abstractions
{
    public abstract class Shape
    {
        protected readonly IColor _color;
        public Shape(IColor color)
        {
            _color = color;
        }

        public abstract void Draw();
    }
}
