using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Mediator.Interfaces
{
    public interface IMediator
    {
        bool AddUser(User user);
        bool RemoveUser(User user);
        bool SendMessage(string message, User sender, User receiver);
    }
}
