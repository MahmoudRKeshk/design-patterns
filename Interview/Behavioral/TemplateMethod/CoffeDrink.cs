using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.TemplateMethod
{
    public class CoffeDrink : HotDrink
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter...");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk...");
        }
    }
}
