using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.TemplateMethod
{
    public class HotChocolate : HotDrink
    {
        protected override void Brew()
        {
            Console.WriteLine("Mixing hot chocolate powder with water...");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding marshmallows and whipped cream...");
        }
    }
}
