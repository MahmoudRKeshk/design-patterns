using Interview.Behavioral.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Mediator.Implementations
{
    internal class MediatorChatHub : IMediator
    {
        public List<User> Users { get; private set; }

        public MediatorChatHub()
        {
            Users = new List<User>();
        }
        public bool AddUser(User user)
        {
            if (user is not null && !Users.Contains(user))
            {
                Users.Add(user);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("INFO: ");
                Console.ResetColor();
                Console.Write($"{user.GentName()} has joined the chat!");
                Console.Write("\n");
                return true;
            }
            return false;
        }

        public bool RemoveUser(User user)
        {
            if (user is null || !Users.Contains(user))
            {
                return false;
            }
            Users.Remove(user);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("INFO: ");
            Console.ResetColor();
            Console.Write($"{user.GentName()} has left the chat.!");
            Console.Write("\n");
            return true;
        }

        public bool SendMessage(string message, User sender, User receiver)
        {
            if (!Users.Contains(sender))
            {
                Console.WriteLine("You can't broad cast a message to a group you are not a member in it!");
            }
            if (!Users.Contains(receiver))
            {
                Console.WriteLine("Invalid Recipient! no such a user found");
                return false;
            }
            receiver.ReceiveMessage(message, sender);
            return true;
        }
    }
}
