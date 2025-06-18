using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Subsystems.Interfaces
{
    public interface IDVD
    {
        void On();
        void Off();
        void Insert(string dvdName);
    }
}
