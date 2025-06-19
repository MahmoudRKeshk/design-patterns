using Interview.Behavioral.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Observer.Implementations
{
    internal class Subscriber : ISubscriber<string>
    {
        public string Username { get; private set; }
        public Subscriber(string name)
        {
            this.Username = name;
        }

        public string GetUsername()
        {
            return this.Username;
        }

        public void Update(string Data)
        {
            Console.WriteLine($"#### BIGNEWS : {Data} @{Username.ToLower()}");
        }

    }
}
