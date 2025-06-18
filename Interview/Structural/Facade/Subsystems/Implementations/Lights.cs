using Interview.Structural.Facade.Subsystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Subsystems.Implementations
{
    public class Lights : ILights
    {
        private bool _isOn = false;  
        private int _dimLevel = 0;


        public void DimLights(int level)
        {
            if (this._isOn == false)
            {
                throw new InvalidOperationException("You can't set the level of the dim if the lights is not on!");
            }
            else
            {
                this._dimLevel = level;
            }
        }

        public void TurnOffLights()
        {
            this._isOn = false;
        }

        public void TurnOnLights()
        {
            this._isOn = true;
        }
    }
}
