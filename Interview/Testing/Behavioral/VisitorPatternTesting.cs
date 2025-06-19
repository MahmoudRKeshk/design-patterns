using Interview.Behavioral.Visitor.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Behavioral
{
    public static class VisitorPatternTesting
    {
        public static void Run()
        {
            // Create instances of animals
            var lion = new Lion();
            var monkey = new Monkey();

            // Performing animal visitor
            var performingVisitor = new PerformingAnimalVisitor();
            lion.Accept(performingVisitor);
            monkey.Accept(performingVisitor);

            // Caregiver visitor
            var caregiverVisitor = new AnimalCaregiverVisitor();
            lion.Accept(caregiverVisitor);
            monkey.Accept(caregiverVisitor);
        }
    }
}
