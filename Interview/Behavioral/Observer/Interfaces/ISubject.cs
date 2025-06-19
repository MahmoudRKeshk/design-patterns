using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Observer.Interfaces
{
    public interface ISubject<T>
    {
        void Notify(T Data);
        void Register(ISubscriber<T> observer);
        void Unregister(ISubscriber<T> observer);
    }
}
