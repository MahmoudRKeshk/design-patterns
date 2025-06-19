using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Mediator.Interfaces
{
    public abstract class User
    {
        protected IMediator _mediator;
        public User(IMediator mediator)
        {
            _mediator = mediator;
        }
        public abstract void SendMessage(string message, User receiver);
        public abstract void ReceiveMessage(string message, User sender);
        public abstract string GentName();
    }
}
