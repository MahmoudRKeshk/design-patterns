using Interview.Behavioral.Visitor.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Behavioral.Visitor.Interfaces
{
    public interface IAnimalVisitor
    {
        void VisitMonkey(Monkey monkey);
        void VisitLion(Lion lion);
    }
}
