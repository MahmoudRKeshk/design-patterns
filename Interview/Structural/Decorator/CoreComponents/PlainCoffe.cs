using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Decorator.CoreComponents
{
    internal class PlainCoffe : ICoffe
    {
        public string GetDescription()
        {
            return "Plain Coffee";
        }
        public double GetCost()
        {
            return 1.00;
        }
    }
}
