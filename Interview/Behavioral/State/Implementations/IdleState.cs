using Interview.Behavioral.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.State.Implementations
{
    public class IdleState : IVendingMachineState
    {
        private VendingMachine _machine;
        public IdleState(VendingMachine vendingMachine)
        {
            this._machine = vendingMachine;
        }

        public void Cancel()
        {
            Console.WriteLine("Nothing to cancel! already in the idle state!"); 
        }

        public void DispenseItem()
        {
            Console.WriteLine("Please Insert money first!");
        }

        public void InsertMoney()
        {
            Console.WriteLine("Money Inseted successfully!");
            _machine.SetState(_machine._hasMoneyState); 
        }
    }
}
