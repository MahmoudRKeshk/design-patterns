using Interview.Behavioral.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.State.Implementations
{
    public class HasMoneyState : IVendingMachineState
    {
        private VendingMachine _machine;
        public HasMoneyState(VendingMachine vendingMachine)
        {
            this._machine = vendingMachine;
        }
        public void Cancel()
        {
            Console.WriteLine("Your money has been withdrawed!");
            _machine.SetState(_machine._idleState);
        }

        public void DispenseItem()
        {
            Console.WriteLine("Here are your item!");
            _machine.SetState(_machine._dispensingState);
        }

        public void InsertMoney()
        {
            Console.WriteLine("Money already inserted");
        }
    }
}
