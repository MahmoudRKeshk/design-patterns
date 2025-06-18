using Interview.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Adapter.Implementations
{
    public class LoggerAdapter : INewLogger  // Inherit from one
    {
        // Encapsulte the other  
        private readonly IOldLogger _oldLogger;

        public LoggerAdapter(IOldLogger oldLogger)
        {
            _oldLogger = oldLogger;
        }

        public void LogError(string message)
        {
            _oldLogger.Log(LogType.Error, message);
        }

        public void LogInfo(string message)
        {
            _oldLogger.Log(LogType.Info, message);
        }

        public void LogWarning(string message)
        {
            _oldLogger.Log(LogType.Warning, message);
        }
    }
}
