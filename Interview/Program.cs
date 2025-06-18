using Interview.Testing;

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
            
            
            #endregion 
        }
    }
}
