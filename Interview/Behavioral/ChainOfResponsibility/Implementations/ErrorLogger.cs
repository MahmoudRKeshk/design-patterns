using Interview.Behavioral.ChainOfResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.ChainOfResponsibility.Implementations
{
    public class ErrorLogger : Logger
    {
        public override bool CanHandle(Severity severity)
        {
            return severity == Severity.error;
        }
        public override void Handle(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[Error] {message}");
            Console.ResetColor();
        }
    }
}
