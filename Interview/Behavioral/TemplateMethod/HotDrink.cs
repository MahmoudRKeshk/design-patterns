using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.TemplateMethod
{
    public abstract class HotDrink
    {
        public void PrepareDrink()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Preparing {this.GetType().Name}...");
            Console.ResetColor();
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        protected abstract void Brew();
        protected abstract void AddCondiments();
        private void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }
        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup...");
        }
    }
}
