using Interview.Structural.Facade.Subsystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Subsystems.Implementations
{
    public class DVD : IDVD
    {
        private string _dvdName;
        private bool _isOn;
        public void Insert(string dvdName)
        {
            this._dvdName = dvdName;
        }

        public void Off()
        {
            this._isOn = false;
        }

        public void On()
        {
            if (string.IsNullOrEmpty(_dvdName))
            {
                throw new InvalidOperationException("No DVD is inserted.");
            }
            this._isOn = true;
        }
    }
}
