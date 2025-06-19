using Interview.Behavioral.ChainOfResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.ChainOfResponsibility.Implementations
{
    internal class WarningLogger : Logger
    {
        public override bool CanHandle(Severity severity)
        {
            return severity == Severity.warning;
        }

        public override void Handle(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"[Warning] {message}");
            Console.ResetColor();
        }
    }
}
