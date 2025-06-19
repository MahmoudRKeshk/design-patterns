using Interview.Behavioral.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Observer.Implementations
{
    public class NewsLetter : ISubject<string>
    {
        private readonly List<ISubscriber<string>> _observers = new List<ISubscriber<string>>();
        
        public void Notify(string Data)
        {
            _observers.ForEach(observer => observer.Update(Data));
        }

        public void Register(ISubscriber<string> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                Console.WriteLine($"[+] {observer.GetUsername()} registered successfully.");
            }
        }

        public void Unregister(ISubscriber<string> observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"[-] {observer.GetUsername()} unregistered successfully.");
        }
    }
}
