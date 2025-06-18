using Interview.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Adapter.Implementations
{
    public class OldLogger : IOldLogger
    {
        public void Log(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.Error:
                Console.WriteLine($"ERROR : {message}");
                break;
                case LogType.Warning:
                Console.WriteLine($"WARNING : {message}");
                break;
                case LogType.Info:
                Console.WriteLine($"INFO : {message}");
                break;
                default:
                Console.WriteLine(message);
                break;
            }
        }
    }
}
