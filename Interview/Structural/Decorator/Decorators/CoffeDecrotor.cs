using Interview.Structural.Decorator.CoreComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Decorator.Decorators
{
    public class CoffeDecrotor : ICoffe
    {
        public virtual string GetDescription()
        {
            return "Coffe Decorator";
        }
        public virtual double GetCost()
        {
            return 0.00;
        }

    }
}
