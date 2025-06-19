using Interview.Behavioral.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.State.Implementations
{
    public class DispensingState : IVendingMachineState
    {
        private VendingMachine _machine;
        public DispensingState(VendingMachine machine)
        {
            this._machine = machine;
        }
        public void Cancel()
        {
            Console.WriteLine("Can't cancel the opearation. despensing started");
        }

        public void DispenseItem()
        {
            Console.WriteLine("Dispensing your item!");
        }

        public void InsertMoney()
        {
            Console.WriteLine("Please wait! Despensing in progress");
        }
    }
}
