using Interview.Structural.Decorator.CoreComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Decorator.Decorators
{
    public class CaramelDecorator : CoffeDecrotor
    {
        protected ICoffe _coffe;
        private readonly double _cost = 0.50;

        public CaramelDecorator(ICoffe coffe)
        {
            _coffe = coffe;
        }

        public override double GetCost()
        {
            return _coffe.GetCost() + _cost;
        }

        public override string GetDescription()
        {
            return $"{_coffe.GetDescription()} + caramel";
        }
    }
}
