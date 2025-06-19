using Interview.Behavioral.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Visitor.Implementations
{
    public class Lion : IAnimal
    {
        public void Accept(IAnimalVisitor visitor)
        {
            visitor.VisitLion(this);
        }

        public void Roar()
        {
            Console.WriteLine("Lion is roaring!");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"lion is eating {food}");
        }
    }
}
