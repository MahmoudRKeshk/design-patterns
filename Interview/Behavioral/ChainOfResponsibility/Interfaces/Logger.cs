using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.ChainOfResponsibility.Interfaces
{
    public enum Severity {
        info,
        warning,
        error
    }
    public abstract class Logger
    {
        private Logger _next;
        public void SetNext(Logger logger)
        {
            _next = logger;
        }

        public void Log(string message, Severity severity)
        {
            if (CanHandle(severity))
            {
                Handle(message);
                return;
            }
            _next?.Log(message, severity);
        }

        public abstract bool CanHandle(Severity severity);
        public abstract void Handle(string message);
    }
}
