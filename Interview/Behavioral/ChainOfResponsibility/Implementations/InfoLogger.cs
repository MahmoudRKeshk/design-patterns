using Interview.Behavioral.ChainOfResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.ChainOfResponsibility.Implementations
{
    public class InfoLogger : Logger
    {
        public override void Handle(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[Info] {message}");
            Console.ResetColor();
        }

        public override bool CanHandle(Severity severity)
        {
            return severity == Severity.info;
        }
    }
}
