using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Adapter.Interfaces
{
    public interface INewLogger
    {
        public void LogInfo(string message);
        public void LogError(string message);
        public void LogWarning(string message);
    }
}
