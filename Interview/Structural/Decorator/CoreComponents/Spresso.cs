using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Decorator.CoreComponents
{
    internal class Spresso : ICoffe
    {
        public string GetDescription()
        {
            return "Spresso Coffee";
        }
        public double GetCost()
        {
            return 1.50;
        }
    }
}
