using Interview.Behavioral.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Strategy.Implementations
{
    public class CashPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing cash payment of {amount:C}.$");
        }
        public string GetPaymentMethodName()
        {
            return "Cash Payment";
        }
    }
}
