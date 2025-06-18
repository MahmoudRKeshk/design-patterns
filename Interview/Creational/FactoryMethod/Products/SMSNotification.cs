using Interview.Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Creational.FactoryMethod.Products
{
    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS Notification sent with message: {message}");
        }
    }
}
