using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Memento
{
    public class BankAccount
    {
        private decimal _balance;
        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
            Console.WriteLine($"Bank account created with initial balance: {_balance:C}");
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");
            _balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New balance: {_balance:C}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");
            if (amount > _balance)
                throw new InvalidOperationException("Insufficient funds for withdrawal.");
            _balance -= amount;
            Console.WriteLine($"Withdrew: {amount:C}. New balance: {_balance:C}");
        }
        public decimal GetBalance()
        {
            return _balance;
        }
        public BankAccountMemento CreateBankAccountMemento()
        {
            return new BankAccountMemento(this.GetBalance());
        }
        public void Restore(BankAccountMemento memento)
        {
            this._balance = memento.Balance;
        }
    }
}
