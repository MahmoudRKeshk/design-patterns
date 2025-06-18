using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Structural.Facade.Facades
{
    public interface IHomeTheater
    {
        void StartWatchingMovie(string movieName);
        void StopWatchingMovie();
    }
}
