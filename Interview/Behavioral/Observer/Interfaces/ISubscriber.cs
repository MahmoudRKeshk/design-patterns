using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Observer.Interfaces
{
    public interface ISubscriber<T>
    {
        public string GetUsername();
        void Update(T Data);
    }
}
