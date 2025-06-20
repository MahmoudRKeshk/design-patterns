using Interview.Behavioral.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Command.Implementations
{
    public enum ActionType
    {
        Deposit,
        Withdraw
    }
    public class BankTransactionCommand : ICommand
    {
        private readonly BankAccount _bankAccount;
        private readonly ActionType _actionType;
        private readonly uint _amount;
        private bool _isExecuted = false;
        public BankTransactionCommand(BankAccount bankAccount, ActionType actionType, uint amount)
        {
            _bankAccount = bankAccount;
            _actionType = actionType;
            _amount = amount;
        }
        public void Execute()
        {
            switch (_actionType)
            {
                case ActionType.Deposit:
                    _bankAccount.Deposit(_amount);
                    _isExecuted = true;
                    break;
                case ActionType.Withdraw:
                    _bankAccount.Withdraw(_amount);
                    _isExecuted = true;
                    break;
                default:
                    throw new InvalidOperationException("Invalid action type.");
            }
        }

        public void Undo()
        {
            if (!_isExecuted)
            {
                return;
            }
            switch (_actionType)
            {
                case ActionType.Deposit:
                    _bankAccount.Withdraw(_amount);
                    break;
                case ActionType.Withdraw:
                    _bankAccount.Deposit(_amount);
                    break;
                default:
                    return; // Invalid action type, do nothing
            }
        }
    }
}
