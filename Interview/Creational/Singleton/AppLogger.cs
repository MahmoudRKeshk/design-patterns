using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.Singleton
{
    public class AppLogger
    {
        private static AppLogger _appLogger = null;

        private AppLogger()
        {
            Console.WriteLine("Logger was initialized!");
        }

        public void Log (string message)
        {
            Console.WriteLine($"Logged Message : { message}");
        }
        public static AppLogger Instance()
        {
            if (_appLogger is null)
            {
                var appLogger = new AppLogger();
                _appLogger = appLogger;
                return appLogger;
            }else 
            { 
                return _appLogger; 
            }
        }
    }
}
