using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Memento
{
    public class BankAccountMemento
    {
        public decimal Balance { get; private set; }
        public BankAccountMemento(decimal balance)
        {
            Balance = balance;
        }
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
