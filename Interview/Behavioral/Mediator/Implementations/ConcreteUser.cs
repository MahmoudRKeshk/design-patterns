using Interview.Behavioral.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Mediator.Implementations
{
    public class ConcreteUser : User
    {
        private string _name;
        public ConcreteUser(string name, IMediator mediator) : base(mediator)
        {
            _name = name;
        }
        public override void ReceiveMessage(string message, User sender)
        {
            Console.WriteLine($"{_name} received message: '{message}' from {sender.GentName()}");
        }

        public override void SendMessage(string message, User receiver)
        {
            this._mediator.SendMessage(message, this, receiver);
        }

        public override string GentName()
        {
            return _name;
        }
    }
}
