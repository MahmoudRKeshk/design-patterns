using Interview.Structural.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Adapter.Implementations
{
    public class NewLogger : INewLogger
    {
        public void LogError(string message) 
        {
            Console.WriteLine($"ERROR : {message}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"INFO : {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"WARNING : {message}");
        }
    }
}
