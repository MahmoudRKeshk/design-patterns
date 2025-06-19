using Interview.Structural.Decorator.CoreComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Decorator.Decorators
{
    public class MilkDecorator : CoffeDecrotor
    {
        protected ICoffe _coffe;
        private readonly double _cost = 0.30;
        public MilkDecorator(ICoffe coffe)
        {
            _coffe = coffe;
        }
        public override double GetCost()
        {
            return _coffe.GetCost() + _cost ;
        }
        public override string GetDescription()
        {
            return $"{_coffe.GetDescription()} + milk";
        }
    }
}
