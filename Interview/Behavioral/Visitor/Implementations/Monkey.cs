using Interview.Behavioral.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Visitor.Implementations
{
    public class Monkey : IAnimal
    {
        public void Accept(IAnimalVisitor visitor)
        {
            visitor.VisitMonkey(this);
        }

        public void Jump()
        {
            Console.WriteLine("Monkey is jumping");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"monkey is eating {food}");
        }
    }
}
