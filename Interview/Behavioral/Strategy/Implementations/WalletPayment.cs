using Interview.Behavioral.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Strategy.Implementations
{
    internal class WalletPayment : IPaymentStrategy
    {
        public string GetPaymentMethodName()
        {
            return "Wallet Payment";
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing wallet payment of {amount:C}.$");
        }
    }
}
