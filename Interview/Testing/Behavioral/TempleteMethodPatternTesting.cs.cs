using Interview.Behavioral.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Behavioral
{
    public abstract class TempleteMethodPatternTesting
    {
        public static void Run()
        {
            var coffee = new CoffeDrink();
            coffee.PrepareDrink();
            Console.WriteLine();

            var tea = new TeaDrink();
            tea.PrepareDrink();
            Console.WriteLine();

            var hotChocolate = new HotChocolate();
            hotChocolate.PrepareDrink();
            Console.WriteLine();

        }
    }
}
