using Interview.Behavioral.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Behavioral
{
    public static class MementoPatternTesting
    {
        public static void Run()
        {
            // Creating the bank account and its initial state
            var bankAccount = new BankAccount(0.0m);
            var bankAccountHistory = new BankAccountHistory();

            // Saving the initial state
            var initialState = bankAccount.CreateBankAccountMemento();
            bankAccountHistory.SaveState(initialState);

            // saving states after transactions
            bankAccount.Deposit(100.0m);
            bankAccountHistory.SaveState(bankAccount.CreateBankAccountMemento());

            bankAccount.Deposit(20.0m);
            bankAccountHistory.SaveState(bankAccount.CreateBankAccountMemento());

            // return to the initial state
            bankAccount.Restore(bankAccountHistory.Undo());
            bankAccount.Restore(bankAccountHistory.Undo());

            // Displaying the final balance after restoring to the initial state
            Console.WriteLine($"Final Balance : {bankAccount.GetBalance()}");


        }
    }
}
