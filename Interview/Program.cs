using Interview.Testing;

namespace Interview
{
    public class Program
    {
        static void Main(string[] args)
        {
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


        }
    }
}
