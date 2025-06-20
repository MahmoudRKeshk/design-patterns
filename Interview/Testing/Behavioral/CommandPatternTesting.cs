using Interview.Behavioral.Command.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Behavioral
{
    public static class CommandPatternTesting
    {
        public static void Run()
        {
            var bankAccount = new BankAccount(1000);
            var depositCommand = new BankTransactionCommand(bankAccount, ActionType.Deposit, 200);
            var withdrawCommand = new BankTransactionCommand(bankAccount, ActionType.Withdraw, 150);

            // Act
            Console.WriteLine("Initial Balance: " + bankAccount.GetBalance());
            depositCommand.Execute();
            withdrawCommand.Execute();
            Console.WriteLine($"Final Balance: {bankAccount.GetBalance()}");


            // Undo the last transaction
            Console.WriteLine("Undoing last transaction (withdrawal)...");
            withdrawCommand.Undo();
            Console.WriteLine($"Balance after undoing withdrawal: {bankAccount.GetBalance()}");
            depositCommand.Undo();
            Console.WriteLine($"Balance after undoing deposit: {bankAccount.GetBalance()}"); 
        }
    }
}
