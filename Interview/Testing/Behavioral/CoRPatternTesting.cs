using Interview.Behavioral.ChainOfResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Behavioral
{
    public static class CoRPatternTesting
    {
        public static void Run()
        {
            // Create loggers
            var infoLogger = new Interview.Behavioral.ChainOfResponsibility.Implementations.InfoLogger();
            var warningLogger = new Interview.Behavioral.ChainOfResponsibility.Implementations.WarningLogger();
            var errorLogger = new Interview.Behavioral.ChainOfResponsibility.Implementations.ErrorLogger();

            infoLogger.SetNext(warningLogger);
            warningLogger.SetNext(errorLogger);
            
            infoLogger.Log("This is an informational message.", Severity.info);
            infoLogger.Log("This is a warning message.", Severity.warning);
            infoLogger.Log("This is an error message.", Severity.error);
        }

    }
}
