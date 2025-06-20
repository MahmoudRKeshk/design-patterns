using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Strategy.Interfaces
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
        string GetPaymentMethodName();
    }
}
