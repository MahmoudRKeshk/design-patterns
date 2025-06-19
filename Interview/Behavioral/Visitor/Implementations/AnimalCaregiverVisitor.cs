using Interview.Behavioral.Visitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Visitor.Implementations
{
    public class AnimalCaregiverVisitor : IAnimalVisitor
    {
        public AnimalCaregiverVisitor()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("[Animal caregiver visitor] has come to the zoo!");
            Console.ResetColor();
        }
        public void VisitLion(Lion lion)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("[Animal caregiver visitor] is visiting a lion.");
            Console.ResetColor();
            lion.Eat("meat");
        }

        public void VisitMonkey(Monkey monkey)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("[Animal caregiver visitor] is visiting a monkey.");
            Console.ResetColor();
            monkey.Eat("banana");
        }
    }
}
