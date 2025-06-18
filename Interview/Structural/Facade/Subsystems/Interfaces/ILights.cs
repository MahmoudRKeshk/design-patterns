using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Subsystems.Interfaces
{
    public interface ILights
    {
        void TurnOnLights();
        void TurnOffLights();
        void DimLights(int level);
    }
}
