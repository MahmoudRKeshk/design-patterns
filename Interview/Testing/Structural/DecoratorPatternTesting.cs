using Interview.Structural.Decorator.CoreComponents;
using Interview.Structural.Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Structural
{
    public static class DecoratorPatternTesting
    {
        public static void Run()
        {
            var coffee = new Spresso();

            // Decorate with milk
            var milkCoffee = new MilkDecorator(coffee);
            Console.WriteLine($"{milkCoffee.GetDescription()} costs {milkCoffee.GetCost()}$");

            // Decorate with caramel
            var caramelCoffee = new CaramelDecorator(coffee);
            Console.WriteLine($"{caramelCoffee.GetDescription()} costs {caramelCoffee.GetCost()}$");

            // Decorate with both milk and caramel
            var milkCaramelCoffee = new CaramelDecorator(milkCoffee);
            Console.WriteLine($"{milkCaramelCoffee.GetDescription()} costs {milkCaramelCoffee.GetCost()}$");
        }
    }
}
