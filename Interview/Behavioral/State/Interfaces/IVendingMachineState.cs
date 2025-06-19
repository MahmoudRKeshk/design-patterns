using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.State.Interfaces
{
    public interface IVendingMachineState
    {
        void Cancel();
        void InsertMoney();
        void DispenseItem();
    }
}
