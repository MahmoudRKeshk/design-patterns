using Interview.Behavioral.Observer.Implementations;
using Interview.Behavioral.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Behavioral
{
    public static class ObserverPatternTesting
    {
        public static void Run()
        {
            ISubject<string> newsLetter = new NewsLetter();
            var subscriber1 = new Subscriber("Mahmoudd");
            var subscriber2 = new Subscriber("Ahmed");


            newsLetter.Register(subscriber1);
            newsLetter.Register(subscriber2);

            newsLetter.Notify("New updates coming from Cairo!");
            newsLetter.Unregister(subscriber1);
            newsLetter.Notify("Here are the latest updates from NYC!");
        }
    }
}
