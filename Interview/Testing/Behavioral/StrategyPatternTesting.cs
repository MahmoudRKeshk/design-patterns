using Interview.Behavioral.Strategy.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Behavioral
{
    public static class StrategyPatternTesting
    {
        public static void Run()
        {
            // Credit Payment
            var creditCardPayment = new CreditCardPayment();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{creditCardPayment.GetPaymentMethodName()}");
            Console.ResetColor();
            var paymentContext01 = new PaymentContext(creditCardPayment);
            paymentContext01.ProcessPayment(100.00m);
           
            // Wallet Payment
            var walletPayment = new WalletPayment();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{walletPayment.GetPaymentMethodName()}");
            Console.ResetColor();
            var paymentContext02 = new PaymentContext(walletPayment);
            paymentContext02.ProcessPayment(50.00m);

            // Cash Payment
            var cashPayment = new CashPayment();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{cashPayment.GetPaymentMethodName()}");
            Console.ResetColor();
            var paymentContext03 = new PaymentContext(cashPayment);
            paymentContext03.ProcessPayment(20.00m);
        }
    }
}
