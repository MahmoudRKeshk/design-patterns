using Interview.Behavioral.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Visitor.Implementations
{
    public class PerformingAnimalVisitor : IAnimalVisitor
    {
        public PerformingAnimalVisitor()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("[Performing animal visitor] has come to the zoo!");
            Console.ResetColor();
        }
        public void VisitMonkey(Monkey monkey)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("[Performing animal visitor] is visiting a monkey.");
            Console.ResetColor();
            monkey.Jump();
        }
        public void VisitLion(Lion lion)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("[Performing animal visitor] is visiting a lion.");
            Console.ResetColor();
            lion.Roar();
        }
    }
}
