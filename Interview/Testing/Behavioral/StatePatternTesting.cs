using Interview.Behavioral.State.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Behavioral
{
    public static class StatePatternTesting
    {
        public static void Run()
        {
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.InsertMoney();
            vendingMachine.DispenseItem();
            vendingMachine.Cancel();

            vendingMachine.InsertMoney();
            vendingMachine.DispenseItem();
            vendingMachine.Cancel();

            vendingMachine.InsertMoney();
            vendingMachine.Cancel();


        }
    }
}
