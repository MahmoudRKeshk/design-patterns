using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Adapter.Interfaces
{
    public enum LogType
    {
        Info,
        Warning,
        Error
    }
    public interface IOldLogger
    {
        void Log(LogType logType, string message);
    }
}
