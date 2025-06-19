using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Behavioral
{
    public static class MediatorPatternTesting
    {
        public static void Run()
        {
            // Create a chathub (mediator)
            var chatHub = new Interview.Behavioral.Mediator.Implementations.MediatorChatHub();
            
            // Create users
            var user1 = new Interview.Behavioral.Mediator.Implementations.ConcreteUser("Mahmoud", chatHub);
            var user2 = new Interview.Behavioral.Mediator.Implementations.ConcreteUser("Sara", chatHub);
            
            // Add users to the mediator
            chatHub.AddUser(user1);
            chatHub.AddUser(user2);
            
            
            // Send amessages
            user1.SendMessage("Hello Sara!", user2);
            user2.SendMessage("Hi Mahmoud!", user1);

            chatHub.RemoveUser(user1);
            user2.SendMessage("Are you there, Mahmoud?", user1);
        }
    }
}
