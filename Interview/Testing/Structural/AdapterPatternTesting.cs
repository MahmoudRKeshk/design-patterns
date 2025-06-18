using Interview.Structural.Adapter.Implementations;
using Interview.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Structural
{
    public static class AdapterPatternTesting
    {
        public static void Run()
        {
            INewLogger _newLogger;

            var oldLogger = new OldLogger();
            _newLogger = new LoggerAdapter(oldLogger);

            // Log some messages
            _newLogger.LogError("something went wrong!");
            _newLogger.LogWarning("this is a warnng for you!");
            _newLogger.LogInfo("keep this info for you!");
        }
    }
}
