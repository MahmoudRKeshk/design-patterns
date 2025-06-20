using Interview.Behavioral.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Strategy.Implementations
{
    public class PaymentContext
    {
        private readonly IPaymentStrategy _paymentStrategy;
        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
