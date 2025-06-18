using Interview.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Testing.Creational
{
    public static class SingletonPatternTesting
    {
        public static void Run()
        {
            AppLogger _loggerOne = AppLogger.Instance();
            _loggerOne.Log("Testing logging with singleton pattern from logger 01");


            AppLogger _loggerTwo = AppLogger.Instance();
            _loggerTwo.Log("Testing logging with singleton pattern from logger 02");
        }
    }
}
