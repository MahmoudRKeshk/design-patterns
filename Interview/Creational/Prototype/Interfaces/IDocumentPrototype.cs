using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.Prototype.Interfaces
{
    public interface IDocumentPrototype
    {
        public abstract IDocumentPrototype Clone();
    }
}
