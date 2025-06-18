using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Subsystems.Interfaces
{
    public interface IProjector
    {
        void TurnOn();
        void TurnOff();
        void SetInputSource(string source);
        void DisplayContent(string content);
    }
}
