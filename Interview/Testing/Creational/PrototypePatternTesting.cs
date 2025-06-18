using Interview.Creational.Prototype.Implementations;
using Interview.Creational.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Creational
{
    public static class PrototypePatternTesting
    {
        public static void Run()
        {
            var report = new Report("Annual Report", "This is the content of the annual report.");
            var letter = new Letter("Mahmoud R. Keshk", "Dear Keshk, this is a letter.");
            
            var clonedReport = report.Clone();
            var clonedLetter = letter.Clone();
            
            Console.WriteLine("Original Report:\n" + report);
            Console.WriteLine("\nCloned Report:\n" + clonedReport);
            
            Console.WriteLine("\nOriginal Letter:\n" + letter);
            Console.WriteLine("\nCloned Letter:\n" + clonedLetter);
        }
    }
}
