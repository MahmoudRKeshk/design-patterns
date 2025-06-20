using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Memento
{
    public class BankAccountHistory
    {
        private readonly Stack<BankAccountMemento> _history = new Stack<BankAccountMemento>();

        public void SaveState(BankAccountMemento memento)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Saving current state...");
            Console.ResetColor();
            _history.Push(memento);
        }

        public BankAccountMemento Undo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Undoing last transaction...");
            Console.ResetColor();
            return _history.Count > 0 ? _history.Pop() : null;
        }
    }
}
