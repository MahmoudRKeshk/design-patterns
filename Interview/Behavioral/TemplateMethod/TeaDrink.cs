using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.TemplateMethod
{
    public class TeaDrink : HotDrink
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping tea leaves in hot water...");
        }
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon and honey...");
        }
    }
}
