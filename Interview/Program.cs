using Interview.Testing.Behavioral;
using Interview.Testing.Creational;
using Interview.Testing.Structural;

namespace Interview
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Creationl Design Patterns
            
            // Run the builder pattern testing
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BilderPattern!");
            Console.ResetColor();
            BuilderPatternTesting.Run();
            Console.WriteLine("\n");

            // FactoryMethod Pattern Testing
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("FactoryMethodPattern!");
            Console.ResetColor();
            FactoryMethodPatternTesting.Run();
            Console.WriteLine("\n");

            // Prototype Pattern Testing
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PrototypePattern!");
            Console.ResetColor();
            PrototypePatternTesting.Run();
            Console.WriteLine("\n");


            // Singleton Pattern Testing
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SingletonPattern");
            Console.ResetColor();
            SingletonPatternTesting.Run();
            Console.WriteLine("\n");

            #endregion

            #region Structural Design Patterns
            
            // Adaptr design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("AdapterDesignPattern");
            Console.ResetColor();
            AdapterPatternTesting.Run();
            Console.WriteLine("\n");

            // Bridge design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BridgeDesignPattern");
            Console.ResetColor();
            BridgePatternTesting.Run();
            Console.WriteLine("\n");

            // Peroxy design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ProxyDesignPattern");
            Console.ResetColor();
            ProxyPatternTesting.Run();
            Console.WriteLine("\n");

            // Composite design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CompositeDesignPattern");
            Console.ResetColor();
            CompositePatternTesting.Run();
            Console.WriteLine("\n");

            // Facade design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("FacadeDesignPattern");
            Console.ResetColor();
            FacadePatternTesting.Run();
            Console.WriteLine("\n");

            // Decorator design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DecoratorDesignPattern");
            Console.ResetColor();
            DecoratorPatternTesting.Run();
            Console.WriteLine("\n");

            // Flyweight design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("FlyweightDesignPattern");
            Console.ResetColor();
            FlyweightPatternTesting.Run();
            Console.WriteLine("\n");

            #endregion

            #region Behavioral Design Patterns

            // Observer design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ObserverDesignPattern");
            Console.ResetColor();
            ObserverPatternTesting.Run();
            Console.WriteLine("\n");

            // State design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("StateDesignPattern");
            Console.ResetColor();
            StatePatternTesting.Run();
            Console.WriteLine("\n");


            // Mediator design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("MediatorDesignPattern");
            Console.ResetColor();
            MediatorPatternTesting.Run();
            Console.WriteLine("\n");

            // Visitor design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("VisitorDesignPattern");
            Console.ResetColor();
            VisitorPatternTesting.Run();
            Console.WriteLine("\n");

            // Chain of Responsibility design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ChainOfResponsibilityDesignPattern");
            Console.ResetColor();
            CoRPatternTesting.Run();
            Console.WriteLine("\n");

            // Command design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CommandDesignPattern");
            Console.ResetColor();
            CommandPatternTesting.Run();
            Console.WriteLine("\n");

            // Template Method design pattern
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TemplateMethodDesignPattern");
            Console.ResetColor();
            TempleteMethodPatternTesting.Run();
            Console.WriteLine("\n");

            #endregion
        }
    }
}
